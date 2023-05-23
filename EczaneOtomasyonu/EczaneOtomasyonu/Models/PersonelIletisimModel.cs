using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace EczaneOtomasyonu.Models
{
    //Personel İletişim için Model Yapısı Oluşturdum verilerim karmaşık şekilde göndermemek için model view controller mantıklı geldi.
    class PersonelIletisimModel : IDisposable
    {
        private string yakaKartNo;
        private string adres;
        private string telefon;
        private string email;


        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public string YakaKartNo { get => yakaKartNo; set => yakaKartNo = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }

        

        public PersonelIletisimModel(string yakaKartNo, string adres, string telefon,string email)
        {

            this.yakaKartNo = yakaKartNo;
            this.adres = adres;
            this.telefon = telefon;
            this.email = email;

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
