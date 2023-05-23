using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace EczaneOtomasyonu.Models
{
    //Hasta Bilgi için Model Yapısı Oluşturdum verilerim karmaşık şekilde göndermemek için model view controller mantıklı geldi.

    class HastaBilgiModel : IDisposable
    {
        private string tcKimlikNo;
        private string adSoyad;
        private string telefon;
        private string adres;
        private string sosyalGuvence;


        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public string TcKimlik { get => tcKimlikNo; set => tcKimlikNo = value; }
        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string Telefon { get => telefon; set => telefon = value; } 
        public string Adres { get => adres; set => adres = value; }
        public string SosyalGuvence { get => sosyalGuvence; set => sosyalGuvence = value; }

        public HastaBilgiModel(string tcKimlikNo, string adSoyad, string telefon, string adres,string sosyalGuvence)
        {

            this.tcKimlikNo = tcKimlikNo;
            this.adSoyad = adSoyad;
            this.telefon = telefon;
            this.adres = adres;
            this.sosyalGuvence = sosyalGuvence;


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
