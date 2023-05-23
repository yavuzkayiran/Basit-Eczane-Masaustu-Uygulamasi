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
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }
        Querry querry = new Querry();
        private void HastaKayit_Load(object sender, EventArgs e)
        {
            HastaKayitYenile();
            //Datagridviewi gizledim çünkü arama yapınca  el ile bağladığımız datagridviewe doldurma işlemi yapamıyorum
            //bende arama yapınca açılan bi datagridview düşündüm.
            dataGridView2.Hide();

        }
        void HastaKayitYenile()
        {
            //DataGriedviewi veri çekme 
            this.hastaBilgiTableAdapter.Fill(this.eczaneDataSet4.HastaBilgi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hasta bilgilerini alıp clasıma gönderiyorum sonra kayıt sql çalışıyor.
            //dönüş olarak true false geliyor
            if (querry.HastaBilgiKaydet(new Models.HastaBilgiModel(textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,comboBox1.Text)))
            {
                MessageBox.Show("Hasta Kaydedildi.");
                HastaKayitYenile();
                Temizle();
            }
            else
            {
                MessageBox.Show("Kayıt Sırasında Bir Sorun Oluştu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hasta bilgi güncellem işlemi yapılıyor verileri clasıma gönderiyorum
            if (querry.HastaBilgiGuncelle(new Models.HastaBilgiModel(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.Text)))
            {
                MessageBox.Show("Hasta Güncellendi.");
                HastaKayitYenile();
                Temizle();
            }
            else
            {
                MessageBox.Show("Güncelleme Sırasında Bir Sorun Oluştu.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hasta silme işlemi yapılıyor hasta tc si ile silme işlemi yapıyorum
            if (querry.HastaBilgiSil(new Models.HastaBilgiModel(textBox2.Text, "", "", "", "")))
            {
                MessageBox.Show("Hasta Silindi.");
                HastaKayitYenile();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silme Sırasında Bir Sorun Oluştu.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridviewe çift tıklanınca verileri çekiyorum ve yerlerine yazıyorum.
            try
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            

        }
        void Temizle()
        {
            //gereken alanları temizliyorum.
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //eğer textboxın changed değişirse bir arama gerçekleşiyor clasımda hasta arama fonksiyonumu çalıştırıyorum
            List<Models.HastaBilgiModel> hastaBilgiListesi = querry.HastaBilgiArama(textBox6.Text);

            if (textBox6.Text != "")
            {
                //text varsa gelen verileri datagridviewe yerleştirip ekrana gösteriyorum.
                dataGridView2.Rows.Clear();
                dataGridView2.Show();

                for (int i = 0; i < hastaBilgiListesi.Count; i++)
                {
                    dataGridView2.Rows.Insert(i, hastaBilgiListesi[i].TcKimlik, hastaBilgiListesi[i].AdSoyad, hastaBilgiListesi[i].Telefon, hastaBilgiListesi[i].Adres, hastaBilgiListesi[i].SosyalGuvence);
                }
            }
            else
            //eğer textboxım boş ise arama yok diyerek datagridview2 gizleyerek datagridview 1 gösteriyorum full dolu olan
            {
                dataGridView2.Hide();

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //arama yapılıp datagridviewe click yapılırsa burda ki verileri textlerime aktarıyorum
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
