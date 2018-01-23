using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;

using camera_console.Properties;


namespace camera_console {
    public partial class frmMain : Form {
        private Cap_Device cap = new Cap_Device();      // カメラデバイス
        Stopwatch swTim = new Stopwatch();              // タイマ処理時間計測用

        private bool form_standby = false;              // フォーム初期処理完了フラグ
        private int timer_count = 65535;                // タイマー撮影カウンタ[sec]


        // ----------------------------------------------------------------------------------------
        // フォーム初期化
        // ----------------------------------------------------------------------------------------
        public frmMain() {
            InitializeComponent();
        }
        // フォームロード
        private void frmMain_Load(object sender, EventArgs e) {
            // コントロール状態設定
            control_state_load();
            camera_initialize(false);
        }
        private void frmMain_Shown(object sender, EventArgs e) {
            form_standby = true;            // コントロールスタンバイ完了
        }


        // ----------------------------------------------------------------------------------------
        // フォームクローズ時
        // ----------------------------------------------------------------------------------------
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            // 設定を保存する
            setting_save();
            // カメラをリリースする
            if (cap.IsOpen) {
                cap.Close();
            }
            cap.Dispose();
            cap = null;
        }

        // ----------------------------------------------------------------------------------------
        // カメラキャプチャタイマ
        // ----------------------------------------------------------------------------------------
        private void timCap_Tick(object sender, EventArgs e) {
            // 画像処理の経過時間を観測する
            swTim.Reset(); swTim.Start();
            Bitmap bmp;
            int timer_lim = int.MaxValue;

            // カメラ画像キャプチャ
            bmp = cap.Read();
            if (bmp == null) {
                lblDebug.Text = "画像が受信できませんでした";
                return;
            }

            // 画像の左右反転
            if (chkMirror.Checked) {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
            }


            // 画面を表示する
            pic.Image = bmp;

            // タイマー撮影 
            // １秒ごとにカウントアップし、設定値を越えていたら画像を保存する
            if (chkTimer.Checked) {
                if (int.TryParse(cmbTimer.Text, out timer_lim)) {
                    if (timer_count > timer_lim) {
                        save_image();
                        timer_count = 0;    // タイマーカウント初期化
                    }
                    // 表示更新
                    lblTimerCount.Text = String.Format("あと {0} 秒です", (timer_lim - timer_count).ToString());
                }
                else {
                    // タイマー設定値がおかしくて保存できない

                }
            }

            // 経過時間を表示する
            swTim.Stop();
            lblDebug.Text = String.Format("時刻:{0} 処理時間:{1} sec", DateTime.Now.ToString("HH:mm:ss:ff"), swTim.ElapsedMilliseconds.ToString());
        }


        // 
        // 1秒基準クロック
        private void timClk1Sec_Tick(object sender, EventArgs e) {
            timer_count++;
        }


        #region private functions

        /// <summary>
        /// UI上のコントロールのパラメータを設定する
        /// </summary>
        private void control_state_load() {
            // 基本 -------------------------------------------------------------------------------

            cmbCam.SelectedIndex = Settings.Default.cam_no;         // カメラNo
            // 解像度
            cmbReso.Items.Clear();
            for (int i = 0; i < cap.Disp_Reso.Length; i++)
                cmbReso.Items.Add(cap.Disp_Reso[i].name);
            cmbReso.SelectedIndex = Settings.Default.cam_reso;
            lblReso_Bar.Text = String.Format("{0} X {1}", cap.Disp_Reso[cmbReso.SelectedIndex].reso.Width.ToString(), cap.Disp_Reso[cmbReso.SelectedIndex].reso.Height.ToString());
            cmbTimer.Text = Settings.Default.tim_interval;      // タイマー撮影間隔
            chkTimer.Checked = Settings.Default.tim_check;      // 定期的に撮る
            chkMirror.Checked = Settings.Default.cv_mirror;     // 画像の左右反転


            // 保存 -------------------------------------------------------------------------------
            // 保存拡張子
            cmbExt.Items.Clear();
            for (int i = 0; i < cap.Image_Ext.Length; i++)
                cmbExt.Items.Add(cap.Image_Ext[i].name);
            cmbExt.SelectedIndex = Settings.Default.cam_ext;
            txtName.Text = Settings.Default.save_filename;          // 保存ファイル名
            // 連番
            txtSnum.Value = Settings.Default.save_snum;             // 連番初期値
            txtSnumB.Value = Settings.Default.save_snumb;           // 下限
            txtSnumU.Value = Settings.Default.save_snumu;           // 上限
            chkDate.Checked = Settings.Default.save_date;           // 日付をつける
            // 保存先ラジオボタン
            if (Settings.Default.save_rbtn_dst == 0) rbtnSave_Desktop.Checked = true;
            else if (Settings.Default.save_rbtn_dst == 1) rbtnSave_Dialog.Checked = true;
            else if (Settings.Default.save_rbtn_dst == 2) rbtnSave_Other.Checked = true;
            if (Settings.Default.save_path.Length > 0) lbtnSave_Other.Text = Settings.Default.save_path;    // 保存先パス

        }

        /// <summary>
        /// 現在の設定を保存する
        /// </summary>
        private void setting_save() {
            // 基本 -------------------------------------------------------------------------------
            Settings.Default.cam_no = cmbCam.SelectedIndex;         // カメラNo
            Settings.Default.cam_reso = cmbReso.SelectedIndex;      // 解像度
            Settings.Default.tim_interval = cmbTimer.Text;          // タイマー撮影間隔
            Settings.Default.tim_check = chkTimer.Checked;          // 定期的に撮る
            Settings.Default.cv_mirror = chkMirror.Checked;         // 画像の左右反転


            // 保存 -------------------------------------------------------------------------------
            Settings.Default.cam_ext = cmbExt.SelectedIndex;        // 拡張子
            Settings.Default.save_filename = txtName.Text;          // 保存ファイル名
            Settings.Default.save_snum = txtSnum.Value;             // 連番初期値
            Settings.Default.save_snumb = txtSnumB.Value;           // 下限
            Settings.Default.save_snumu = txtSnumU.Value;           // 上限
            Settings.Default.save_date = chkDate.Checked;           // 日付をつける
            // 保存先ラジオボタン
            if (rbtnSave_Desktop.Checked) Settings.Default.save_rbtn_dst = 0;
            else if (rbtnSave_Dialog.Checked) Settings.Default.save_rbtn_dst = 1;
            else if (rbtnSave_Other.Checked) Settings.Default.save_rbtn_dst = 2;
            Settings.Default.save_path = lbtnSave_Other.Text;       // 保存先パス

            Settings.Default.Save();
        }

        /// <summary>
        /// カメラデバイスを初期化する
        /// </summary>
        /// <param name="f">初期化が再実行かどうか</param>
        /// <returns></returns>
        private bool camera_initialize(bool f) {
            // カメラがすでにオープンされている
            if (f) {
                timCap.Stop(); pic.Image = null;
                cap.Close();
            }
            // カメラオープン
            if (cap.Open(cmbCam.SelectedIndex, cmbReso.SelectedIndex)) {
                timCap.Start();
                return true;
            }
            else {
                // カメラオープン失敗
                MessageBox.Show(
                    "カメラが見つかりませんでした\r\n" +
                    "・USBカメラささってますか\r\n" +
                    "・つかうカメラの番号はあってますか　カメラ１台なら番号は「0」です\r\n",
                    "No capture device.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        /// <summary>
        /// 現在の画像を保存する
        /// </summary>
        /// <returns></returns>
        private bool save_image() {
            string savepath = "";
            string filename = "";
            string ext = "";

            // 画像がなければ何もしない
            if (pic.Image == null) return false;

            timCap.Stop();
            try {
                if (!rbtnSave_Dialog.Checked) {
                    // 保存先パスの設定
                    if (rbtnSave_Desktop.Checked) {
                        // デスクトップ
                        savepath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\";
                    }
                    else if (rbtnSave_Other.Checked) {
                        // それ以外のどこか、有効なパスならそれ以外のどこかにぶちこむ
                        if (Directory.Exists(lbtnSave_Other.Text)) {
                            savepath = lbtnSave_Other.Text;
                        }
                        else {
                            lblMessage.Text = "それ以外のどこかの、そのパスが無効です";
                            timCap.Start();
                            return false;
                        }
                    }
                    // 保存ファイル名の生成
                    if (txtName.Text.Length == 0) {
                        // テキストボックスが空欄なので強制的に日付にする
                        filename = DateTime.Now.ToString("yyyyMMddHHmmss");
                    }
                    else {
                        // 設定に従いファイル名生成
                        filename = txtName.Text;
                        // 日付を付加するなら末尾に付加
                        if (chkDate.Checked) filename += DateTime.Now.ToString("yyyyMMddHHmmss");
                        // 連番が含まれる
                        if (filename.IndexOf("*") >= 0) {
                            // 連番に置き換える
                            filename = filename.Replace("*", txtSnum.Value.ToString());
                            // 連番の処理
                            if (txtSnum.Value >= txtSnumU.Value) txtSnum.Value = 0;
                            else txtSnum.Value += 1;    // 連番を１つ増やす
                        }
                    }
                }
                else {
                    // 毎回きく　＝　ダイアログで保存
                    sfdSaveFile.FileName = DateTime.Now.ToString("yyyyMMddHHmmss");
                    if (sfdSaveFile.ShowDialog() == DialogResult.OK) {
                        savepath = sfdSaveFile.FileName;
                        filename = "";
                    }
                    else {
                        lblMessage.Text = "キャンセルしました";
                        timCap.Start();
                        return false;
                    }
                }

                // 拡張子
                ext = cap.Image_Ext[cmbExt.SelectedIndex].ext;
                pic.Image.Save(savepath + filename + ext);
                timCap.Start();
                lblMessage.Text = String.Format(filename + ext + " 保存しました ({0})", DateTime.Now.ToString("HH:mm:ss"));
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.HResult.ToString() + ":" + ex.Message, "Fetal error image saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /// <summary>
        /// タイマー状態を切り替える
        /// </summary>
        /// <param name="t">タイマインスタンス</param>
        /// <param name="s">true:Start(), false:Stop()</param>
        private void timer_switch(Timer t, bool s) {
            if (s) {
                t.Start();
            }
            else {
                t.Stop();
            }
        }



        #endregion



        #region テストコード

        // テスト：１キャプチャ
        private void btnTest_Click(object sender, EventArgs e) {
            Cap_Device cd = new Cap_Device();
            cd.Open(0, 4);
            pic.Image = cd.Read();
            cd.Close();
            cd.Dispose();
        }




        #endregion



        // ----------------------------------------------------------------------------------------
        // 現在の画面を保存する
        // ----------------------------------------------------------------------------------------
        private void btnCapture_Click(object sender, EventArgs e) {
            // カメラが接続されていれば
            if (cap.IsOpen) {
                save_image();
            }
            else {
                MessageBox.Show("カメラが起動していません\r\n" +
                    "カメラ番号を確認してください", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ----------------------------------------------------------------------------------------
        // 定期的に撮影するチェックの切り替え
        // ----------------------------------------------------------------------------------------
        private void chkTimer_CheckedChanged(object sender, EventArgs e) {
            timer_count = 0;            // タイマーカウント初期化
            if (chkTimer.Checked) {
                if (cap.IsOpen) {
                    // 毎回聞くの場合たいへんなのでメッセージでお知らせする
                    if (rbtnSave_Dialog.Checked) {
                        MessageBox.Show("保存先が[毎回きく]になっています\r\n" +
                            "これは時間が経つと毎回ダイアログで聞かれることに\r\n" + "" +
                            "なってしまうので気を付けてください", "念のため確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else {
                    chkTimer.Checked = false;
                    MessageBox.Show("カメラが起動していません\r\n" +
                        "カメラ番号を確認してください", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // 表示、有効の切り替え
            timer_switch(timClk1Sec, chkTimer.Checked); // タイマー撮影ならカウントStart
            btnCapture.Enabled = !chkTimer.Checked;     // タイマー撮影なら撮影ボタン無効
            lblTimerCount.Visible = chkTimer.Checked;   // タイマー撮影ならカウントダウン表示
        }


        // ----------------------------------------------------------------------------------------
        // カメラ再選択
        // ----------------------------------------------------------------------------------------
        private void cmbCam_SelectedIndexChanged(object sender, EventArgs e) {
            if (form_standby) {
                camera_initialize(true);
            }
        }
        // ----------------------------------------------------------------------------------------
        // 解像度再選択
        // ----------------------------------------------------------------------------------------
        private void cmbReso_SelectedIndexChanged(object sender, EventArgs e) {
            if (form_standby) {
                camera_initialize(true);
            }
            lblReso_Bar.Text = String.Format("{0} X {1}", cap.reso.Width.ToString(), cap.reso.Height.ToString());
        }

        // 撮影タイマー時間変更
        private void cmbTimer_TextChanged(object sender, EventArgs e) {
            int i;
            // 数字でなければアウト
            if (!int.TryParse(cmbTimer.Text, out i)) {
                if (cmbTimer.Text.Length > 0) {
                    // メッセージはうっとうしいので無効
                    //MessageBox.Show("その値は無効です", "入力した値がすさまじい", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTimer.Text = cmbTimer.Text.Substring(0, cmbTimer.Text.Length - 1);   // 入力した1文字減らす
                }
                else {
                    cmbTimer.Text = "1";    // 空欄なら初期値
                }
            }
            else if (i <= 0){
                cmbTimer.Text = "1";        // 0以下なら初期値
            }
            timer_count = 0;        // タイマーカウント初期化
        }






        // 保存拡張子変更
        private void cmbExt_SelectedIndexChanged(object sender, EventArgs e) {
            lblExt.Text = cap.Image_Ext[cmbExt.SelectedIndex].ext;
        }


        // 連番変更
        private void txtSnum_ValueChanged(object sender, EventArgs e) {
            // 上限を越えるなら上限にする
            if (txtSnum.Value > txtSnumU.Value) txtSnum.Value = txtSnumU.Value;
            // 下限未満なら下限にする
            if (txtSnum.Value < txtSnumB.Value) txtSnum.Value = txtSnumB.Value;
        }
        // 連番下限変更
        private void txtSnumB_ValueChanged(object sender, EventArgs e) {
            // 上限を越えるなら下げる
            if (txtSnumB.Value > txtSnumU.Value) txtSnumB.Value--;
            // 連番設定値が下限未満なら下限にする
            if (txtSnum.Value < txtSnumB.Value) txtSnum.Value = txtSnumB.Value;
        }
        // 連番上限変更
        private void txtSnumU_ValueChanged(object sender, EventArgs e) {
            // 下限未満なら下限と等しくする
            if (txtSnumU.Value < txtSnumB.Value) {
                txtSnumU.Value = txtSnumB.Value;
            }
            // 連番設定値が上限を越えるなら上限にする
            if (txtSnum.Value > txtSnumU.Value) {
                txtSnum.Value = txtSnumU.Value;
            }
        }

        // 保存先設定のボタン
        private void btnSave_Other_Click(object sender, EventArgs e) {
            if (ofdSavePath.ShowDialog() == DialogResult.OK) {
                lbtnSave_Other.Text = Path.GetDirectoryName(ofdSavePath.FileName) + "\\";

            }
        }

        // 設定された保存先を開く
        private void lbtnSave_Other_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                if (Directory.Exists(lbtnSave_Other.Text)) {
                    Process.Start(lbtnSave_Other.Text);
                }
                else {
                    MessageBox.Show("設定されているパスが無効です\r\n"
                        + "設定ボタンで正しく設定してください", "Invalid directory path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.HResult.ToString() + ":" + ex.Message);
            }
        }

        // ----------------------------------------------------------------------------------------
        // ファイル名テキストボックス変更後
        // ----------------------------------------------------------------------------------------
        private void txtName_TextChanged(object sender, EventArgs e) {
            // 無効な文字は削除する

        }

        private void btnLicenseOC3_Click(object sender, EventArgs e) {
            try {
                Process.Start(Application.StartupPath + "\\license\\OpenCV_License.txt");
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
