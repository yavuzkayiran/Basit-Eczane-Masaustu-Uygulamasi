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
    public partial class IlacBilgi : Form
    {
        public IlacBilgi()
        {
            InitializeComponent();
        }
        Querry querry = new Querry();
        private void IlacBilgi_Load(object sender, EventArgs e)
        {
            IlacBilgiYenile();
            KisileriDoldur();
            tarihiGecmisKontrol();
            dataGridView2.Hide();
        }
        void IlacBilgiYenile()
        {
            this.ilacBilgiTableAdapter.Fill(this.eczaneDataSet3.IlacBilgi);

        }
        void tarihiGecmisKontrol()
        {
            //Burda veritabanımdan ilaç tarihini alıp bugün ile karşılaştırıyorum
            //geçen var ise listboxa ekleyip tarihi geçmiş ilaçları listeliyorum
            List<Models.IlacBilgiModel> ilacBilgiListesi = querry.IlaCBilgiTarihKontrol();
            listBox1.Items.Clear();
            for (int i = 0; i < ilacBilgiListesi.Count; i++)
            {

                TimeSpan ts =DateTime.Now.Date- ilacBilgiListesi[i].SonKullanmaTarihi.Date;
   
                if (Convert.ToInt32(ts.Days)>0)
                {
                    listBox1.Items.Add(ilacBilgiListesi[i].Barkod + " " + ilacBilgiListesi[i].IlacAdi + " " + ilacBilgiListesi[i].SonKullanmaTarihi.Date.ToString("dd.MM.yyyy"));
                }



            }

        }
        
        void KisileriDoldur()
        {
            //veritabanımdan personle bilgilerini alıp combobaxa yerleştiriyorum 
            List<Models.PersonelBilgiModel> personelBilgiListesi;
            comboBox1.Items.Clear();
            personelBilgiListesi = querry.PersonelBilgiGetir();
            for (int i = 0; i < personelBilgiListesi.Count; i++)
            {
                comboBox1.Items.Add(personelBilgiListesi[i].YakaKartNo + " " + personelBilgiListesi[i].AdSoyad);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //arama işlemi yapıyorum göstermek için yine önceki yerlerde açıkladığım gibi kontrol yapıp 
            //datagridview dolduruyorum.
            List<Models.IlacBilgiModel> ilacBilgiListesi = querry.IlaCBilgiArama(textBox1.Text);

            if (textBox1.Text != "")
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Show();
                
                for (int i = 0; i < ilacBilgiListesi.Count; i++)
                {
                    dataGridView2.Rows.Insert(i,ilacBilgiListesi[i].Barkod,ilacBilgiListesi[i].IlacAdi, ilacBilgiListesi[i].Firma, ilacBilgiListesi[i].SonKullanmaTarihi.Date.ToString("dd.MM.yyyy"), ilacBilgiListesi[i].KutuSayisi, ilacBilgiListesi[i].Fiyat, ilacBilgiListesi[i].KullanimNedeni, ilacBilgiListesi[i].YanEtkileri, ilacBilgiListesi[i].TeslimAlanYakaKartNo);
                }
            }
            else
            {
                dataGridView2.Hide();

            }
        }
        void Temizle()
        {
            //temizleme işlemi yapıyorum
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "")
            {
                string[] yakaKartNo = comboBox1.Text.Split(' ');
                if (querry.IlacBilgiKaydet(new Models.IlacBilgiModel(textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value.Date, int.Parse(textBox5.Text), float.Parse(textBox6.Text), textBox7.Text, textBox8.Text, yakaKartNo[0])))
                {

                    MessageBox.Show("İlaç Bilgileri Kaydedildi.");
                    IlacBilgiYenile();
                    tarihiGecmisKontrol();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Kayıt Sırasında Bir Hata Oluştu!");

                }
            }
            else
            {
                MessageBox.Show("Lütfen Personel Seçiniz.");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string[] yakaKartNo = comboBox1.Text.Split(' ');
                if (querry.IlacBilgiGuncelle(new Models.IlacBilgiModel(textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value.Date, int.Parse(textBox5.Text), float.Parse(textBox6.Text), textBox7.Text, textBox8.Text, yakaKartNo[0])))
                {

                    MessageBox.Show("İlaç Bilgileri Güncellendi.");
                    IlacBilgiYenile();
                    tarihiGecmisKontrol();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme Sırasında Bir Hata Oluştu!");

                }
            }
            else
            {
                MessageBox.Show("Lütfen Personel Seçiniz.");
            }


        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            if (querry.IlacBilgiSil(new Models.IlacBilgiModel(textBox2.Text,"","",dateTimePicker1.Value,-1,-1,"","","")))
            {

                MessageBox.Show("İlaç Bilgisi Silindi.");
                IlacBilgiYenile();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silme Sırasında Bir Hata Oluştu!");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                
                

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        
    }
}
