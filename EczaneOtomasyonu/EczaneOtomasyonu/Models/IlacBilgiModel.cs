using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace EczaneOtomasyonu.Models
{
    //İlaç bilgi için Model Yapısı Oluşturdum verilerim karmaşık şekilde göndermemek için model view controller mantıklı geldi.

    class IlacBilgiModel : IDisposable
    {
        private string barkod;
        private string ilacAdi;
        private string firma;
        private DateTime sonKullanmaTarihi;
        private int kutuSayisi;
        private float fiyat;
        private string kullanimNedeni;
        private string yanEtkileri;
        private string teslimAlanYakaKartNo;
       


        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public string Barkod { get => barkod; set => barkod = value; }
        public string IlacAdi { get => ilacAdi; set => ilacAdi = value; }
        public string Firma { get => firma; set => firma = value; }
        public DateTime SonKullanmaTarihi { get => sonKullanmaTarihi; set => sonKullanmaTarihi = value; }
        public int KutuSayisi { get => kutuSayisi; set => kutuSayisi = value; }
        public float Fiyat { get => fiyat; set => fiyat = value; }
        public string KullanimNedeni { get => kullanimNedeni; set => kullanimNedeni = value; }
        public string YanEtkileri { get => yanEtkileri; set => yanEtkileri = value; }
        public string TeslimAlanYakaKartNo { get => teslimAlanYakaKartNo; set => teslimAlanYakaKartNo = value; }

        public IlacBilgiModel(string barkod, string ilacAdi, string firma, DateTime sonKullanmaTarihi, int kutuSayisi, float fiyat, string kullanimNedeni, string yanEtkileri, string teslimAlanYakaKartNo)
        {


            this.barkod = barkod;
            this.ilacAdi = ilacAdi;
            this.firma = firma;
            this.sonKullanmaTarihi = sonKullanmaTarihi;
            this.kutuSayisi = kutuSayisi;
            this.fiyat = fiyat;
            this.kullanimNedeni = kullanimNedeni;
            this.yanEtkileri = yanEtkileri;
            this.teslimAlanYakaKartNo = teslimAlanYakaKartNo;


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
