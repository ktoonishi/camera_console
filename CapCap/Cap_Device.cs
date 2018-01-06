using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;


using System.Drawing.Imaging;

using OpenCvSharp;
using OpenCvSharp.Extensions;



namespace camera_console
{
    class Cap_Device : Cap_Definition
    {
        // ----------------------------------------------------------------------------------------
        // プライベート変数
        // ----------------------------------------------------------------------------------------
        private VideoCapture _cap;                  // カメラデバイスキャプチャクラス
        private Camera_Properties _cap_prop;        // カメラ撮影プロパティ
        private Size _cap_reso;                     // カメラ画像解像度
        private Rect _cap_trim;                     // カメラ画像の抽出範囲

        private Mat _frame_org;                     // オリジナルフレーム
        private int _cam_no;                         // カメラNo







        // ----------------------------------------------------------------------------------------
        // 
        // ----------------------------------------------------------------------------------------

        public Cap_Device()
        {
            this._cap = new VideoCapture();
        }


        /// <summary>
        /// カメラデバイスオープン
        /// </summary>
        /// <param name="no">デバイスインデックス[0- ]</param>
        /// <returns>[true]：成功, [false]：失敗</returns>
        public bool Open(int no, int reso_id)
        {
            try
            {
                this._cam_no = no;          // カメラNo保持
                this._cap.Open(this._cam_no);
                if (!this._cap.IsOpened())
                {
                    return false;       // カメラデバイスオープン失敗
                }

                // カメラ初期設定
                this.reso = Disp_Reso[reso_id].reso;    // 画像解像度設定
                _cap.FrameWidth = this._cap_reso.Width; _cap.FrameHeight = this._cap_reso.Height;
                this._cap_reso.Width = _cap.FrameWidth; this._cap_reso.Height = _cap.FrameHeight;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// カメラデバイスクローズ
        /// </summary>
        public void Close()
        {
            try
            {
                if (this._cap.IsOpened())
                {
                    this._cap.Release();
                }
            }
            catch (Exception)
            {

            }
        }




        /// <summary>
        /// カメラデバイスから画像をキャプチャ
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Bitmap Read()
        {
            try
            {
                if (this._cap.IsOpened())
                    if (this._cap.Read(this._frame_org))
                        // 画像データをBitmap変換し返す
                        return BitmapConverter.ToBitmap(this._frame_org);

                // nullを返す
                return null; // new System.Drawing.Bitmap(this._cap_reso.Width, this._cap_reso.Height);
            }
            catch (Exception)
            {
                return null;
            }
        }




        //public string[] GetDeviceList()
        //{
        //    // ToDo
        //    return new string[] { "" };
        //}


        #region properties

        /// <summary>
        /// カメラデバイスのオープンステート
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return _cap.IsOpened();
            }
        }


        /// <summary>
        /// 解像度
        /// </summary>
        public Size reso
        {
            set
            {
                this._cap_reso = value;
                // フレーム配列再生成
                if (this._frame_org != null) this._frame_org.Dispose(); // 不要リソース解放
                this._frame_org = new Mat(this._cap_reso, MatType.CV_8S);
            }
            get
            {
                return this._cap_reso;
            }
        }



        #endregion

        #region Dispose
        private bool disposed = false;
        //SafeFileHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        protected override void Dispose(bool disposing)
        {
            if (disposed) return;       // Disposed has already been called.
            if (disposing)
            {
                //handle.Dispose();
                // マネージリソースの解放
                this.Close();
                if (this._frame_org != null)
                    this._frame_org.Dispose();
            }
            // アンマネージリソースの解放
            // ToDo

            disposed = true;
            base.Dispose(disposing);
        }



        #endregion


    }
}
