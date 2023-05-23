using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace EczaneOtomasyonu.Models
{

    class yetkiBilgiModel : IDisposable
    {
        private int id;
        private string yetki;
        


        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public int Id { get => id; set => id = value; }

        public string Yetki { get => yetki; set => yetki = value; }
        
       

        public yetkiBilgiModel(int id, string yetki)
        {


            this.id = id;
            this.yetki = yetki;
           


        }





        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

    }
}
