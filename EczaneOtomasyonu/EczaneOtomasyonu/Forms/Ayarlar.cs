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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        Querry querry = new Querry();

        List<Models.PersonelBilgiModel> personelBilgiListesi;
        List<Models.yetkiBilgiModel> yetkiBilgiListesi;
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            GirisBilgiYenile();
            kisileriDoldur();
            yetkileriDoldur();
        }
        void kisileriDoldur()
        {
            //listboxuma personelleri çekiyorum.
            listBox1.Items.Clear();
            personelBilgiListesi = querry.PersonelBilgiGetir();
            for (int i = 0; i < personelBilgiListesi.Count; i++)
            {
                listBox1.Items.Add(personelBilgiListesi[i].YakaKartNo + " " + personelBilgiListesi[i].AdSoyad);
            }
        }
        void yetkileriDoldur()
        {
            //burada veritabanımdan yetkileri çekiyorum ve combobaxa atıyorum.
            comboBox1.Items.Clear();
            yetkiBilgiListesi = querry.YetkiBilgiGetir();
            for (int i = 0; i < yetkiBilgiListesi.Count; i++)
            {
                comboBox1.Items.Add(yetkiBilgiListesi[i].Id + " " + yetkiBilgiListesi[i].Yetki);
            }

        }
        void GirisBilgiYenile()
        {
            this.girisBilgiTableAdapter.Fill(this.eczaneDataSet2.GirisBilgi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //bu butonda seçilen personelin yaka kartını textboxuma aktarıyorum.
                string[] yakaKartNo = listBox1.SelectedItem.ToString().Split(' ');
                textBox3.Text = yakaKartNo[0];
                MessageBox.Show("Kullanıcı Yaka Kart No Alındı.");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen kişi seçtiğinizden emin olun.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //eğer bilgelir eksik ise mesaj verdiriyorum.
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.");
            }
            else
            {
                try
                {
                    //Bilgiler tam ise personel kullanıcı adını ve şifresini kaydediyorum.
                    string[] yetkiId = comboBox1.SelectedItem.ToString().Split(' ');
                    if (querry.GirisBilgiKaydet(new Models.girisBilgiModel(textBox1.Text, textBox2.Text, int.Parse(yetkiId[0]), int.Parse(textBox3.Text))))
                    {
                        MessageBox.Show("Giris Ayarları Başarılı Bir Şekilde Kaydedildi");
                        GirisBilgiYenile();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Sırasında Hata Oluştu.");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen Yetki Seçtiğinizden Emin Olun.");
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //personel güncelleme
            if (comboBox1.Text==""||textBox1.Text==""||textBox2.Text==""||textBox3.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.");
            }
            else
            {
                try
                {
                    string[] yetkiId = comboBox1.SelectedItem.ToString().Split(' ');
                    if (querry.GirisBilgiGuncelle(new Models.girisBilgiModel(textBox1.Text, textBox2.Text, int.Parse(yetkiId[0]), int.Parse(textBox3.Text))))
                    {
                        MessageBox.Show("Giris Ayarları Başarılı Bir Şekilde Güncellendi");
                        GirisBilgiYenile();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Sırasında Hata Oluştu.");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen Yetki Seçtiğinizden Emin Olun.");
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //personel silme
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.");
            }
            else
            {
                try
                {

                    if (querry.GirisBilgiSil(new Models.girisBilgiModel("", "", -1, int.Parse(textBox3.Text))))
                    {
                        MessageBox.Show("Giris Ayarları Başarılı Bir Şekilde Silindi");
                        GirisBilgiYenile();
                    }
                    else
                    {
                        MessageBox.Show("Silme Sırasında Hata Oluştu.");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen Yetki Seçtiğinizden Emin Olun.");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seçilen personlein bilgilerini gerekli alanlara çekiyorum
           
            try
            {
               
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
