using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EczaneOtomasyonu.Forms
{
    public partial class IlacSatis : Form
    {
        public IlacSatis()
        {
            InitializeComponent();
        }
        Querry querry = new Querry();
        double ilacToplamTutar = 0;

        private void IlacSatis_Load(object sender, EventArgs e)
        {
            IlacBilgiYenile();
            HastaBilgiYenile();
            KisileriDoldur();
            dataGridView3.Hide();
            dataGridView4.Hide();

        }
        void IlacBilgiYenile()
        {
            this.ilacBilgiTableAdapter.Fill(this.eczaneDataSet6.IlacBilgi);

        }
        void HastaBilgiYenile()
        {
            this.hastaBilgiTableAdapter.Fill(this.eczaneDataSet5.HastaBilgi);

        }
        void KisileriDoldur()
        {
            //personelleri combobaxa atıyorum.
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
            //hasta arama işlemi yaptırıyorum önceki sayfalarda açıkladığım gibi
            List<Models.HastaBilgiModel> hastaBilgiListesi = querry.HastaBilgiArama(textBox1.Text);

            if (textBox1.Text != "")
            {
                dataGridView3.Rows.Clear();
                dataGridView3.Show();

                for (int i = 0; i < hastaBilgiListesi.Count; i++)
                {
                    dataGridView3.Rows.Insert(i, hastaBilgiListesi[i].TcKimlik, hastaBilgiListesi[i].AdSoyad, hastaBilgiListesi[i].Telefon, hastaBilgiListesi[i].Adres, hastaBilgiListesi[i].SosyalGuvence);
                }
            }
            else
            {
                dataGridView3.Hide();

            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //ilaç arama işlemi yaptırıyorum önceki sayfalarda açıkladığım gibi

            List<Models.IlacBilgiModel> ilacBilgiListesi = querry.IlaCBilgiArama(textBox2.Text);

            if (textBox2.Text != "")
            {
                dataGridView4.Rows.Clear();
                dataGridView4.Show();

                for (int i = 0; i < ilacBilgiListesi.Count; i++)
                {
                    dataGridView4.Rows.Insert(i, ilacBilgiListesi[i].Barkod, ilacBilgiListesi[i].IlacAdi, ilacBilgiListesi[i].SonKullanmaTarihi.Date.ToString("dd.MM.yyyy"), ilacBilgiListesi[i].KutuSayisi, ilacBilgiListesi[i].Fiyat, ilacBilgiListesi[i].KullanimNedeni, ilacBilgiListesi[i].YanEtkileri);
                }
            }
            else
            {
                dataGridView4.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //temizle butonum gereken alanları temizliyor.
            listView1.Items.Clear();
            textBox4.Clear();
            ilacToplamTutar = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seçilen hastanın tc sini textboxa aktarıyorum.
            try
            {
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
              
            }
            catch (Exception)
            {

            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //burada seçilen ilacın adedini kullanıcıdan inputbox ile alıyorum
            string ilacAdet = Interaction.InputBox("Adet Giriniz.", "İlaç Satış", "", 520, 300);
            bool anahtar = true;
            //inputbox üzerinden iptal tuşuna basıldığında hata vermemesi için lenght kontrolu yapıp girilmişmi
            //sayı girilmemiş mi kontrolü yapıyorum
            if (ilacAdet.Length>0)
            {
                //burada listedeki elemanları kontrol edip daha önce eklenen ilaç varsa adetini arttırmak için kontrol yapıyorum.

                //buradaki listede eleman yok ise ilk ekleme diyerek direkt listeye kayıt yapıyorum
                if (listView1.Items.Count == 0)
                {
                    string[] veri = { dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString(), ilacAdet };
                    ListViewItem satir = new ListViewItem(veri);
                    listView1.Items.Add(satir);
                    ilacToplamTutar = +ilacToplamTutar + (float.Parse(ilacAdet) * float.Parse(dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString()));
                    textBox4.Text = ilacToplamTutar.ToString();
                }
                else
                {
                    //eğer listede eleman varsa tek tek bakıyorum aynı ilaç var mı diye 
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {

                        if (dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() == listView1.Items[i].SubItems[0].Text)
                        {
                            //aynı ilaç var ise adetini ve fiyatının değiştiriyorum.
                            listView1.Items[i].SubItems[3].Text = (Convert.ToInt32(listView1.Items[i].SubItems[3].Text) + Convert.ToInt32(ilacAdet)).ToString();
                            ilacToplamTutar = +ilacToplamTutar + (float.Parse(ilacAdet) * float.Parse(dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString()));
                            textBox4.Text = ilacToplamTutar.ToString();
                            anahtar = false;
                            break;
                        }
                    }
                    //eğer aynı ilaç yok ise burada olup olmadığını anahtar ile kontrol ediyorum
                    if (anahtar == true)
                    {
                        //listeye yeni ilaç olarak ekliyorum.
                        string[] veri = { dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString(), ilacAdet };
                        ListViewItem satir = new ListViewItem(veri);
                        listView1.Items.Add(satir);
                        ilacToplamTutar = +ilacToplamTutar + (float.Parse(ilacAdet) * float.Parse(dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString()));
                        textBox4.Text = ilacToplamTutar.ToString();

                    }
                }
            }
           
            


        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //hastanını tcsini alıyorum
            try
            {
                textBox3.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            catch (Exception)
            {

                
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //arama yapıp farklı datatgridview açıldığında aynı işlemleri yapsın diye kodları burayada kopyladım
            //burası aramdan sonra açılan datagridview 
            string ilacAdet = Interaction.InputBox("Adet Giriniz.", "İlaç Satış", "", 520, 300);
            bool anahtar = true;

            if (ilacAdet.Length > 0)
            {
                if (listView1.Items.Count == 0)
                {
                    string[] veri = { dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString(), ilacAdet };
                    ListViewItem satir = new ListViewItem(veri);
                    listView1.Items.Add(satir);
                    ilacToplamTutar = +ilacToplamTutar + (float.Parse(ilacAdet) * float.Parse(dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString()));
                    textBox4.Text = ilacToplamTutar.ToString();
                }
                else
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {

                        if (dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString() == listView1.Items[i].SubItems[0].Text)
                        {
                            listView1.Items[i].SubItems[3].Text = (Convert.ToInt32(listView1.Items[i].SubItems[3].Text) + Convert.ToInt32(ilacAdet)).ToString();
                            ilacToplamTutar = +ilacToplamTutar + (float.Parse(ilacAdet) * float.Parse(dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString()));
                            textBox4.Text = ilacToplamTutar.ToString();
                            anahtar = false;
                            break;
                        }
                    }
                    if (anahtar == true)
                    {

                        string[] veri = { dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString(), ilacAdet };
                        ListViewItem satir = new ListViewItem(veri);
                        listView1.Items.Add(satir);
                        ilacToplamTutar = +ilacToplamTutar + (float.Parse(ilacAdet) * float.Parse(dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString()));
                        textBox4.Text = ilacToplamTutar.ToString();

                    }
                }
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //eğer listeye çift tıklanırsa adet düşüyor
           
            //bu if te adet 1 ise listeden o ilacı kaldırıyorum. 
            if (Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text) ==1)
            {
                ilacToplamTutar = (ilacToplamTutar - (float.Parse(listView1.SelectedItems[0].SubItems[2].Text) * 1));
                textBox4.Text = ilacToplamTutar.ToString();
                listView1.SelectedItems[0].Remove();

            }
            else
            {
                //adet birden fazla ise adet ve fiyat güncellemesi yapıyorum.
                ilacToplamTutar = (ilacToplamTutar - (float.Parse(listView1.SelectedItems[0].SubItems[2].Text) * 1));
                textBox4.Text = ilacToplamTutar.ToString();
                listView1.SelectedItems[0].SubItems[3].Text = (Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text)-1).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //veriler tam girilmemişse uyarı verdiriyorum
            if (textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || listView1.Items.Count==0)
            {
                MessageBox.Show("Lütfen bilgileri kontrol edin eksik bilgi var.");
            }
            else
            {
                //veriler tam ise liseteyi sırayla kontrol edip kaydediyor 

                //ilacSatisKontrolde stok durumlarına bakıyoruz stok yeterli ise kayıt işlemi başlıyor
                //stok yeterli değilse kullanıcıya mesaj verdiriliyor.
                if (ilacSatisStokKontrol() == "")
                {
                    string[] yakakNo = comboBox1.Text.Split(' ');
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (querry.IlacSatisKaydet(new Models.IlacSatisBilgiModel(-1, textBox3.Text, listView1.Items[i].SubItems[0].Text, yakakNo[0], DateTime.Now.Date, DateTime.Now.ToString("HH:mm"), float.Parse(listView1.Items[i].SubItems[2].Text), Convert.ToInt32(listView1.Items[i].SubItems[3].Text), (Convert.ToInt32(listView1.Items[i].SubItems[3].Text) * float.Parse(listView1.Items[i].SubItems[2].Text)))) == false)
                        {
                            MessageBox.Show("Satış Esnasında Bir Sorun Oluştu. Kayıt Gerçekleşmedi");
                            break;
                        }
                        else
                        {
                            //querry.IlacStokGuncelle(new Models.IlacBilgiModel(listView1.Items[i].SubItems[0].Text, "", "", DateTime.Now, Convert.ToInt32(listView1.Items[i].SubItems[3].Text), -1, "", "", ""));
                            IlacBilgiYenile();
                            Temizle();
                        }

                    }
                    MessageBox.Show("İşlem Tamamlandı.");
                }

                else
                {
                    MessageBox.Show(ilacSatisStokKontrol() + " Stok Miktarını Karşılamıyor");

                }
            }
        }
     
       void Temizle()
        {
            listView1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
        }
        string ilacSatisStokKontrol()
        {
            //sonda bir tane boş satır var -1 kadar dönmesi gerekiyor
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            {
                
                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    //ilacın barkodu satış listesiyle aynı ise adetlerine bak
                    if (dataGridView2.Rows[i].Cells[0].Value.ToString()==listView1.Items[j].SubItems[0].Text)
                    {
                        //stok adedi istenenden az ise ilaç adını gönder kullanıcıya mesaj verdir.
                        if (Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value.ToString())<Convert.ToInt32(listView1.Items[j].SubItems[3].Text))
                        {
                            return dataGridView2.Rows[i].Cells[1].Value.ToString();
                        }
                    }
                }
                

            }
            //değil ise boş değer döndür satışı yap stokdan düş
            return "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Burada ilaç yan etkileri detaylı bakılması için form açılıyor
            //buradaki tablomu view ile gösteriyorum.
            IlacYanEtkileri ilacYanEtkileri = new IlacYanEtkileri();
            ilacYanEtkileri.ShowDialog();
        }
    }
}
