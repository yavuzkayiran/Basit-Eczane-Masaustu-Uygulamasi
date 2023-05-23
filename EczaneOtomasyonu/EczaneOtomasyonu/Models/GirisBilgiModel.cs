using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace EczaneOtomasyonu.Models
{
    //Giriş için Model Yapısı Oluşturdum verilerim karmaşık şekilde göndermemek için model view controller mantıklı geldi.
    class girisBilgiModel : IDisposable
    {
       
        private string kullaniciAdi;
        private string sifre;
        private int yetkiId;
        private int yakaKartNo;


        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Sifre { get => sifre; set => sifre = value; }

        public int YetkiId { get => yetkiId; set => yetkiId = value; }
        public int YakaKartNo { get => yakaKartNo; set => yakaKartNo = value; }


        public girisBilgiModel(string kullaniciAdi, string sifre, int yetkiId,int yakaKartNo)
        {


            
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.yetkiId = yetkiId;
            this.yakaKartNo = yakaKartNo;


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
         
            }

         
            disposed = true;
        }

    }
}
