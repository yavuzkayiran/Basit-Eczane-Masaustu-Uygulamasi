using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace EczaneOtomasyonu.Models
{
    //Personel Bilgi için Model Yapısı Oluşturdum verilerim karmaşık şekilde göndermemek için model view controller mantıklı geldi.
    class PersonelBilgiModel : IDisposable
    {
        private string yakaKartNo;
        private string adSoyad;
        private string tcKimlikNo;
        private DateTime dogumTarihi;
        private DateTime iseGirisTarihi;
        private string sigorta;


        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public string YakaKartNo { get => yakaKartNo; set => yakaKartNo = value; }
        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string TcKimlikNo { get => tcKimlikNo; set => tcKimlikNo = value; }
        public DateTime DogumTarihi { get => dogumTarihi; set => dogumTarihi = value; }
        public DateTime IseGirisTarihi { get => iseGirisTarihi; set => iseGirisTarihi = value; }
        public string Sigorta { get => sigorta; set => sigorta = value; }

        public PersonelBilgiModel(string yakaKartNo, string adSoyad, string tcKimlikNo, DateTime dogumTarihi,DateTime iseGirisTarihi,string sigorta)
        {


            this.yakaKartNo = yakaKartNo;
            this.adSoyad = adSoyad;
            this.tcKimlikNo =tcKimlikNo;
            this.dogumTarihi = dogumTarihi;
            this.iseGirisTarihi = iseGirisTarihi;
            this.sigorta = sigorta;


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
