using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonu.Forms
{
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }
        Querry querry = new Querry();

        List<Models.PersonelBilgiModel> personelBilgiListesi;
        private void PersoneKayit_Load(object sender, EventArgs e)
        {
            //Fonksiyonlarımı çalıştırıyorum
            personelBilgiYenile();
            personelIletisimYenile();
            kisileriDoldur();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Models.PersonelIletisimModel> personelIletisimListesi = querry.PersonelIletisimGetir();
            personelBilgiListesi = querry.PersonelBilgiGetir();
            //listeden seçilen verileri alanına doldurma
            //listbox dan seçilen verinin yaka kart nosunu alıp o kişinin bilgilerini gereken alanlara doldurma
            try
            {
                
                string[] yakaNo = listBox1.SelectedItem.ToString().Split(' ');
                for (int i = 0; i < personelBilgiListesi.Count; i++)
                {
                    if (personelBilgiListesi[i].YakaKartNo==yakaNo[0])
                    {
                        textBox1.Text = personelBilgiListesi[i].YakaKartNo.ToString();
                        textBox2.Text = personelBilgiListesi[i].AdSoyad;
                        textBox3.Text = personelBilgiListesi[i].TcKimlikNo;
                        dateTimePicker1.Value = personelBilgiListesi[i].DogumTarihi;
                        dateTimePicker2.Value = personelBilgiListesi[i].IseGirisTarihi;
                        comboBox1.Text= personelBilgiListesi[i].Sigorta;
                        textBox4.Text = personelIletisimListesi[i].Adres;
                        textBox5.Text = personelIletisimListesi[i].Telefon;
                        textBox6.Text = personelIletisimListesi[i].Email;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir kişi seçtiğinizden emin olun.");
                Console.WriteLine(e.ToString());
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //querry clasımdan personel kaydet fonksiyonunu çalıştırıp kayıt yapıyorum dönüş değeri true ise kayıt
            //başarılı false ise kayıt başarılı değil
            if (querry.PersonelBilgiKaydet(new Models.PersonelBilgiModel(textBox1.Text,textBox2.Text,textBox3.Text,dateTimePicker1.Value,dateTimePicker2.Value,comboBox1.Text)))
            {
                if (querry.PersonelIletisimKaydet(new Models.PersonelIletisimModel(textBox1.Text,textBox4.Text,textBox5.Text,textBox6.Text)))
                {
                    MessageBox.Show("Personel Bilgileri Kaydedildi.");
                    personelIletisimYenile();
                    personelBilgiYenile();
                    kisileriDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme Sırasında Bir Hata Oluştu!");

                }
            }
            else
            {
                MessageBox.Show("Kayıt Sırasında Bir Hata Oluştu!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //querry clasımdan personel güncelle fonksiyonunu çalıştırıp kayıt yapıyorum dönüş değeri true ise kayıt
            //başarılı false ise kayıt başarılı değil
            if (querry.PersonelBilgiGuncelle(new Models.PersonelBilgiModel(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, dateTimePicker2.Value, comboBox1.Text)))
            {
                if (querry.PersonelIletisimGuncelle(new Models.PersonelIletisimModel(textBox1.Text, textBox4.Text, textBox5.Text, textBox6.Text)))
                {
                    MessageBox.Show("Personel Bilgileri Güncellendi.");
                    personelIletisimYenile();
                    personelBilgiYenile();
                    kisileriDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme Sırasında Bir Hata Oluştu!");

                }
            }
            else
            {
                MessageBox.Show("Güncelleme Sırasında Bir Hata Oluştu!");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //querry clasımdan personel silme fonksiyonunu çalıştırıp kayıt yapıyorum dönüş değeri true ise kayıt
            //başarılı false ise kayıt başarılı değil
            if (querry.PersonelBilgiSil(new Models.PersonelBilgiModel(textBox1.Text, "", "", dateTimePicker2.Value, dateTimePicker1.Value, "")))
            {

                MessageBox.Show("Personel Bilgileri Silindi.");
                personelIletisimYenile();
                personelBilgiYenile();
                kisileriDoldur();
                Temizle();

            }
            else
            {
                MessageBox.Show("Silme Sırasında Bir Hata Oluştu!");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Tüm textleri temizliyor
            Temizle();
        }
        void personelBilgiYenile()
        {
            //Fonksiyonum personel datagridview çekiyor
            this.personelBilgiTableAdapter.Fill(this.eczaneDataSet.PersonelBilgi);

        }
        void personelIletisimYenile()
        {
            //Fonksiyonum personel iletişim datagridview çekiyor
            this.personelIletisimBilgiTableAdapter.Fill(this.eczaneDataSet1.PersonelIletisimBilgi);

        }
        void kisileriDoldur()
        {
            //listbox içerisine kayıtlı olan personelleri çekiyorum.
            listBox1.Items.Clear();
            personelBilgiListesi = querry.PersonelBilgiGetir();
            for (int i = 0; i < personelBilgiListesi.Count; i++)
            {
                listBox1.Items.Add(personelBilgiListesi[i].YakaKartNo + " " + personelBilgiListesi[i].AdSoyad);
            }
        }
        void Temizle()
        {
            //Temizle fonksiyonum işlem yaptıktan sonra gerekene yerlerin içerisini boşaltıyor.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        
    }
}
