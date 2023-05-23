using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.IO;
using System.Drawing;
using System.Windows.Forms;


namespace EczaneOtomasyonu
{
    class Querry
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-87IUBD0;Initial Catalog=Eczane;Integrated Security=True");
        
        //Personel bilgileri çekme
        public List<Models.PersonelBilgiModel> PersonelBilgiGetir()
        {

            List<Models.PersonelBilgiModel> personelBilgiListesi = new List<Models.PersonelBilgiModel>();
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from PersonelBilgi";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Models.PersonelBilgiModel personelBilgi = new Models.PersonelBilgiModel(dr["YakaKartNo"].ToString(), dr["AdSoyad"].ToString(), dr["TcKimlikNo"].ToString(), DateTime.Parse(dr["DogumTarihi"].ToString()), DateTime.Parse(dr["IseGirisTarihi"].ToString()), dr["Sigorta"].ToString());
                    personelBilgiListesi.Add(personelBilgi);


                }
                baglanti.Close();
                return personelBilgiListesi;



            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return personelBilgiListesi;
            }

        }
        public List<Models.PersonelIletisimModel> PersonelIletisimGetir()
        {

            List<Models.PersonelIletisimModel> personelIletisimListesi = new List<Models.PersonelIletisimModel>();
            try
            {
              
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from PersonelIletisimBilgi";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Models.PersonelIletisimModel personelIletisim = new Models.PersonelIletisimModel(dr["YakaKartNo"].ToString(), dr["Adres"].ToString(), dr["Telefon"].ToString(), dr["Email"].ToString());
                    personelIletisimListesi.Add(personelIletisim);


                }
                baglanti.Close();
                return personelIletisimListesi;



            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return personelIletisimListesi;
            }

        }
        //Personel Bilgi ve iletişim Kaydetme
        public Boolean PersonelBilgiKaydet(Models.PersonelBilgiModel personelBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "insert into PersonelBilgi(YakaKartNo,AdSoyad,TcKimlikNo,DogumTarihi,IseGirisTarihi,Sigorta) values (@yakakartno,@adsoyad,@tckimlikno,@dogumtarihi,@isegiristarihi,@sigorta)";
                cmd.Parameters.AddWithValue("@yakakartno", personelBilgiModel.YakaKartNo);
                cmd.Parameters.AddWithValue("@adsoyad", personelBilgiModel.AdSoyad);
                cmd.Parameters.AddWithValue("@tckimlikno", personelBilgiModel.TcKimlikNo);
                cmd.Parameters.AddWithValue("@dogumtarihi", personelBilgiModel.DogumTarihi);//
                cmd.Parameters.AddWithValue("@isegiristarihi", personelBilgiModel.IseGirisTarihi);//
                cmd.Parameters.AddWithValue("@sigorta", personelBilgiModel.Sigorta);//
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public Boolean PersonelIletisimKaydet(Models.PersonelIletisimModel personelIletisimModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "insert into PersonelIletisimBilgi(YakaKartNo,Adres,Telefon,Email) values (@yakakartno,@adres,@telefon,@email)";
                cmd.Parameters.AddWithValue("@yakakartno", personelIletisimModel.YakaKartNo);
                cmd.Parameters.AddWithValue("@adres", personelIletisimModel.Adres);
                cmd.Parameters.AddWithValue("@telefon", personelIletisimModel.Telefon);
                cmd.Parameters.AddWithValue("@email",personelIletisimModel.Email);//
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        //Personel Bilgi ve iletişim Güncelleme
        public Boolean PersonelBilgiGuncelle(Models.PersonelBilgiModel personelBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "update PersonelBilgi set AdSoyad=@adsoyad,TcKimlikNo=@tckimlikno,DogumTarihi=@dogumtarihi,IseGirisTarihi=@isegiristarihi,Sigorta=@sigorta where YakaKartNo=@yakakartno";
                cmd.Parameters.AddWithValue("@yakakartno", personelBilgiModel.YakaKartNo);
                cmd.Parameters.AddWithValue("@adsoyad", personelBilgiModel.AdSoyad);
                cmd.Parameters.AddWithValue("@tckimlikno", personelBilgiModel.TcKimlikNo);
                cmd.Parameters.AddWithValue("@dogumtarihi", personelBilgiModel.DogumTarihi);//
                cmd.Parameters.AddWithValue("@isegiristarihi", personelBilgiModel.IseGirisTarihi);//
                cmd.Parameters.AddWithValue("@sigorta", personelBilgiModel.Sigorta);//
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public Boolean PersonelIletisimGuncelle(Models.PersonelIletisimModel personelIletisimModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "update PersonelIletisimBilgi set Adres=@adres,Telefon=@telefon,Email=@email where YakaKartNo=@yakakartno";
                cmd.Parameters.AddWithValue("@yakakartno", personelIletisimModel.YakaKartNo);
                cmd.Parameters.AddWithValue("@adres", personelIletisimModel.Adres);
                cmd.Parameters.AddWithValue("@telefon", personelIletisimModel.Telefon);
                cmd.Parameters.AddWithValue("@email",personelIletisimModel.Email);//
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        //Personel Bilgi silme ve Personel iletişim Stored Procedure kullanarak silme 
        public Boolean PersonelBilgiSil(Models.PersonelBilgiModel personelBilgiModel)   
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "delete from PersonelBilgi where YakaKartNo=@yakakartno";
                cmd.Parameters.AddWithValue("@yakakartno", personelBilgiModel.YakaKartNo);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
       
        //Ayarlar yetki çekme
        public List<Models.yetkiBilgiModel> YetkiBilgiGetir()
        {

            List<Models.yetkiBilgiModel> yetkiBilgiListesi = new List<Models.yetkiBilgiModel>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from YetkiBilgi";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Models.yetkiBilgiModel yetkiBilgi = new Models.yetkiBilgiModel(int.Parse(dr["id"].ToString()),dr["Yetki"].ToString());
                    yetkiBilgiListesi.Add(yetkiBilgi);


                }
                baglanti.Close();
                return yetkiBilgiListesi;



            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return yetkiBilgiListesi;
            }

        }

        //Ayarlar Sekmesi Kullanıcı Giriş Ayarları
        //Kullanıcı Sorgusu ve yetki dönüşü
        //Giriş işlemleri Stored Procedure Kullanılarak Yapıldı
        public Boolean GirisBilgiKaydet(Models.girisBilgiModel girisBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "GirisBilgiKayit";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullaniciadi", girisBilgiModel.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", girisBilgiModel.Sifre);
                cmd.Parameters.AddWithValue("@yetkiid", girisBilgiModel.YetkiId);
                cmd.Parameters.AddWithValue("@yakakartno", girisBilgiModel.YakaKartNo);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public Boolean GirisBilgiGuncelle(Models.girisBilgiModel girisBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "GirisBilgiGuncelle";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullaniciadi", girisBilgiModel.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", girisBilgiModel.Sifre);
                cmd.Parameters.AddWithValue("@yetkiid", girisBilgiModel.YetkiId);
                cmd.Parameters.AddWithValue("@yakakartno", girisBilgiModel.YakaKartNo);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public Boolean GirisBilgiSil(Models.girisBilgiModel girisBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;               
                cmd.CommandText = "GirisBilgiSil";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@yakakartno", girisBilgiModel.YakaKartNo);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public int Giris(Models.girisBilgiModel girisBilgiModel)
        {
            //giriş fonksiyonum içerisine giriş model alıp kontrol yapıyo ve sonuç olarak yetki id si veriyor.

            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "GirisBilgiGetir";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullaniciAdi", girisBilgiModel.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", girisBilgiModel.Sifre);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    int yetkiId = Convert.ToInt32(dr[2].ToString());
                    baglanti.Close();

                    return yetkiId;
                }
                dr.Close();
                baglanti.Close();
                return 0;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return 0;
            }

        }

        //İlaç Bilgi Sayfası Arama
        public List<Models.IlacBilgiModel> IlaCBilgiArama(string aranaKelime)

        {

            List<Models.IlacBilgiModel> ilacBilgiListesi = new List<Models.IlacBilgiModel>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from IlacBilgi where IlacAdi LIKE '" + aranaKelime + "%'";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Models.IlacBilgiModel ilacBilgi = new Models.IlacBilgiModel(dr["Barkod"].ToString(), dr["IlacAdi"].ToString(), 
                        dr["Firma"].ToString(), DateTime.Parse(dr["SonKullanimTarihi"].ToString()),
                        int.Parse(dr["KutuSayisi"].ToString()), float.Parse(dr["Fiyat"].ToString()), 
                        dr["KullanimNedeni"].ToString(), dr["YanEtkileri"].ToString(), dr["TeslimAlanYakaKartNo"].ToString());
                    ilacBilgiListesi.Add(ilacBilgi);


                }
                baglanti.Close();
                return ilacBilgiListesi;



            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return ilacBilgiListesi;
            }

        }

        //İlaç Bilgi Son Kullanma Tarihi Kontrol 
        public List<Models.IlacBilgiModel> IlaCBilgiTarihKontrol()

        {

            List<Models.IlacBilgiModel> ilacBilgiListesi = new List<Models.IlacBilgiModel>();
            try
            {
              
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from IlacBilgi";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Models.IlacBilgiModel ilacBilgi = new Models.IlacBilgiModel(dr["Barkod"].ToString(), dr["IlacAdi"].ToString(),
                        dr["Firma"].ToString(), DateTime.Parse(dr["SonKullanimTarihi"].ToString()),
                        int.Parse(dr["KutuSayisi"].ToString()), float.Parse(dr["Fiyat"].ToString()),
                        dr["KullanimNedeni"].ToString(), dr["YanEtkileri"].ToString(), dr["TeslimAlanYakaKartNo"].ToString());
                    ilacBilgiListesi.Add(ilacBilgi);


                }
                baglanti.Close();
                return ilacBilgiListesi;



            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return ilacBilgiListesi;
            }

        }

        //İlaç Bilgi Kaydet
        public Boolean IlacBilgiKaydet(Models.IlacBilgiModel ilacBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "insert into IlacBilgi(Barkod,IlacAdi,Firma,SonKullanimTarihi,KutuSayisi,Fiyat,KullanimNedeni,YanEtkileri,TeslimAlanYakaKartNo)" +
                " values(@barkod,@ilacadi,@firma,@sonkullanimtarihi,@kutusayisi,@fiyat,@kullanimnedeni,@yanetkileri,@teslimalanyakakartno)";
                cmd.Parameters.AddWithValue("@barkod", ilacBilgiModel.Barkod);
                cmd.Parameters.AddWithValue("@ilacadi", ilacBilgiModel.IlacAdi);
                cmd.Parameters.AddWithValue("@firma", ilacBilgiModel.Firma);
                cmd.Parameters.AddWithValue("@sonkullanimtarihi", ilacBilgiModel.SonKullanmaTarihi);//
                cmd.Parameters.AddWithValue("@kutusayisi", ilacBilgiModel.KutuSayisi);//
                cmd.Parameters.AddWithValue("@fiyat", ilacBilgiModel.Fiyat);//
                cmd.Parameters.AddWithValue("@kullanimnedeni", ilacBilgiModel.KullanimNedeni);//
                cmd.Parameters.AddWithValue("@yanetkileri", ilacBilgiModel.YanEtkileri);//
                cmd.Parameters.AddWithValue("@teslimalanyakakartno", ilacBilgiModel.TeslimAlanYakaKartNo);//
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        //İlaç Bilgi Güncelle
        public Boolean IlacBilgiGuncelle(Models.IlacBilgiModel ilacBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "update IlacBilgi set IlacAdi=@ilacadi,Firma=@firma,SonKullanimTarihi=@sonkullanimtarihi,KutuSayisi=@kutusayisi,Fiyat=@fiyat,KullanimNedeni=@kullanimnedeni,YanEtkileri=@yanetkileri,TeslimAlanYakaKartNo=@teslimalanyakakartno where Barkod=@barkod";
                cmd.Parameters.AddWithValue("@barkod", ilacBilgiModel.Barkod);
                cmd.Parameters.AddWithValue("@ilacadi", ilacBilgiModel.IlacAdi);
                cmd.Parameters.AddWithValue("@firma", ilacBilgiModel.Firma);
                cmd.Parameters.AddWithValue("@sonkullanimtarihi", ilacBilgiModel.SonKullanmaTarihi);//
                cmd.Parameters.AddWithValue("@kutusayisi", ilacBilgiModel.KutuSayisi);//
                cmd.Parameters.AddWithValue("@fiyat", ilacBilgiModel.Fiyat);//
                cmd.Parameters.AddWithValue("@kullanimnedeni", ilacBilgiModel.KullanimNedeni);//
                cmd.Parameters.AddWithValue("@yanetkileri", ilacBilgiModel.YanEtkileri);//
                cmd.Parameters.AddWithValue("@teslimalanyakakartno", ilacBilgiModel.TeslimAlanYakaKartNo);//
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        // İlaç Bilgi Sil
        public Boolean IlacBilgiSil(Models.IlacBilgiModel ilacBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "delete from IlacBilgi where Barkod=@barkod";
                cmd.Parameters.AddWithValue("@barkod", ilacBilgiModel.Barkod);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        //Hasta Kayıt 
        public Boolean HastaBilgiKaydet(Models.HastaBilgiModel hastaBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "insert into HastaBilgi(TcKimlik,AdSoyad,Telefon,Adres,SosyalGuvence) values(@tckimlik,@adsoyad,@telefon,@adres,@sosyalguvence)";
                cmd.Parameters.AddWithValue("@tckimlik", hastaBilgiModel.TcKimlik);
                cmd.Parameters.AddWithValue("@adsoyad", hastaBilgiModel.AdSoyad);
                cmd.Parameters.AddWithValue("@telefon", hastaBilgiModel.Telefon);
                cmd.Parameters.AddWithValue("@adres", hastaBilgiModel.Adres);//
                cmd.Parameters.AddWithValue("@sosyalguvence", hastaBilgiModel.SosyalGuvence);//          
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        //Hasta Güncelle
        public Boolean HastaBilgiGuncelle(Models.HastaBilgiModel hastaBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "update HastaBilgi set AdSoyad=@adsoyad,Telefon=@telefon,Adres=@adres,SosyalGuvence=@sosyalguvence where TcKimlik=@tckimlik";
                cmd.Parameters.AddWithValue("@tckimlik", hastaBilgiModel.TcKimlik);
                cmd.Parameters.AddWithValue("@adsoyad", hastaBilgiModel.AdSoyad);
                cmd.Parameters.AddWithValue("@telefon", hastaBilgiModel.Telefon);
                cmd.Parameters.AddWithValue("@adres", hastaBilgiModel.Adres);//
                cmd.Parameters.AddWithValue("@sosyalguvence", hastaBilgiModel.SosyalGuvence);//          
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        //Hasta Sil
        public Boolean HastaBilgiSil(Models.HastaBilgiModel hastaBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "delete from HastaBilgi where TcKimlik=@tckimlik";
                cmd.Parameters.AddWithValue("@tckimlik", hastaBilgiModel.TcKimlik);       
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        //Hasta Arama
        public List<Models.HastaBilgiModel> HastaBilgiArama(string aranaKelime)

        {

            List<Models.HastaBilgiModel> hastaBilgiListesi = new List<Models.HastaBilgiModel>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from HastaBilgi where TcKimlik LIKE '" + aranaKelime + "%'";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Models.HastaBilgiModel hastaBilgi = new Models.HastaBilgiModel(dr["TcKimlik"].ToString(), dr["AdSoyad"].ToString(), dr["Telefon"].ToString(), dr["Adres"].ToString(),dr["SosyalGuvence"].ToString());
                    hastaBilgiListesi.Add(hastaBilgi);


                }
                baglanti.Close();
                return hastaBilgiListesi;



            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return hastaBilgiListesi;
            }

        }

        //İlaç Satış Kayıt
        public Boolean IlacSatisKaydet(Models.IlacSatisBilgiModel ilacSatisBilgiModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "IlacSatisKaydet";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@musteritc",ilacSatisBilgiModel.MusteriTc);
                cmd.Parameters.AddWithValue("@ilacbarkod", ilacSatisBilgiModel.IlacBarkod);
                cmd.Parameters.AddWithValue("@personelyakakartno", ilacSatisBilgiModel.PersonelYakaKartNo);
                cmd.Parameters.AddWithValue("@tarih", ilacSatisBilgiModel.Tarih);
                cmd.Parameters.AddWithValue("@saat", ilacSatisBilgiModel.Saat);
                cmd.Parameters.AddWithValue("@adetfiyati", ilacSatisBilgiModel.AdetFiyati);       
                cmd.Parameters.AddWithValue("@adet",ilacSatisBilgiModel.Adet);
                cmd.Parameters.AddWithValue("@toplamtutar", ilacSatisBilgiModel.ToplamTutar);      
                cmd.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        
       


    }

}
