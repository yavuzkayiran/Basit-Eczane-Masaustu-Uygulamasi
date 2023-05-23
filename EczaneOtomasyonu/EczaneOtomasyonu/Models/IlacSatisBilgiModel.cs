using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace EczaneOtomasyonu.Models
{

    class IlacSatisBilgiModel : IDisposable
    {
        private int id;
        private string musteriTc;
        private string ilacBarkod;
        private string personelYakaKartNo;
        private DateTime tarih;
        private string saat;
        private float adetFiyati;
        private int adet;
        private float toplamTutar;
        



        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public int Id { get => id; set => id = value; }
        public string MusteriTc { get => musteriTc; set => musteriTc = value; }
        public string IlacBarkod { get => ilacBarkod; set => ilacBarkod = value; }
        public string PersonelYakaKartNo { get => personelYakaKartNo; set => personelYakaKartNo = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public string Saat { get => saat; set => saat = value; }
        public float AdetFiyati { get => adetFiyati; set => adetFiyati = value; }
        public int Adet { get => adet; set => adet = value; }
        public float ToplamTutar { get => toplamTutar; set => toplamTutar = value; }
       

        public IlacSatisBilgiModel(int id, string musteriTc, string ilacBarkod,string personelYakaKartNo, DateTime tarih,string saat, float adetFiyati, int adet,float toplamTutar)
        {


            this.id = id;
            this.musteriTc = musteriTc;
            this.ilacBarkod = ilacBarkod;
            this.personelYakaKartNo= personelYakaKartNo;
            this.tarih = tarih;
            this.saat = saat;
            this.adetFiyati = adetFiyati;
            this.adet = adet;
            this.toplamTutar = toplamTutar;


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
