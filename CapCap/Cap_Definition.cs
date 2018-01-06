using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;


using OpenCvSharp;

namespace camera_console
{
    class Cap_Definition : IDisposable
    {
        public Cap_Definition()
        {
        }

        ~Cap_Definition()
        {
            Dispose(false);
        }

        // ----------------------------------------------------------------------------------------
        // 列挙体
        // ----------------------------------------------------------------------------------------

        // 画像のカラーモード 
        // *** 多分使わないので未実装にした ***
        // public enum Color_mode { full = 0, mono, sepia };
        
        // 保存時の画像拡張子
        public Ext_Type[] Image_Ext = new Ext_Type[]
        {
            new Ext_Type{name = "PNG", ext = ".png"},
            new Ext_Type{name = "JPEG", ext = ".jpg"},
            new Ext_Type{name = "Bitmap", ext = ".bmp"}
        };
            
        // 画面解像度
        public Reso_Type[] Disp_Reso = new Reso_Type[]
        {
            new Reso_Type{name = "VGA", reso = new Size(640, 480), discription = "これは小さい" },
            new Reso_Type{name = "HD", reso = new Size(1280, 720), discription = "普通のサイズです" },
            new Reso_Type{name = "UXGA", reso = new Size(1600, 1200), discription = "普通のサイズです"  },
            new Reso_Type{name = "FHD", reso = new Size(1920, 1080), discription = "普通のサイズです"  },
            new Reso_Type{name = "5.0MPx", reso = new Size(2592, 1944), discription = "ちょっと大きいです"  },
            new Reso_Type{name = "すーぱー最大", reso = new Size(4000, 3000), discription = "できるだけ大きくします"  }
        };




        // ----------------------------------------------------------------------------------------
        // 構造体
        // ----------------------------------------------------------------------------------------

        // カメラ撮影プロパティ
        protected struct Camera_Properties
        {
            public int brightness;             // 明るさ
            public int contrasst;              // コントラスト
            public int saturation;             // 彩度
            public int hue;                    // 色相
            public int gain;                   // ゲイン
            public int exposure;               // 露出
            public int white_balance;          // (not supported)
        }


        public struct Ext_Type
        {
            public string name;                 // 拡張子の表示名
            public string ext;                  // 拡張子
        }

        public struct Reso_Type
        {
            public string name;                 // 解像度の名称
            public Size reso;                   // 画素
            public string discription;          // 説明
        }


        #region IDisposable

        // Dispose実行確認フラグ
        bool disposed = false;
        SafeFileHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // 呼び出し用Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Disposeパターン
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;   // Dispose has already been called.
            if (disposing)
            {
                handle.Dispose();
                // マネージリソースの解放
                // ToDo
            }
            // アンマネージリソースの解放
            // ToDo
            disposed = true;
        }



        #endregion


    }
}
