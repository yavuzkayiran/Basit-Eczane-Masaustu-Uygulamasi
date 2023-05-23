using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Querry querry = new Querry();
        private void button1_Click(object sender, EventArgs e)
        {
            //Sonuc bize yetkiyi veriyor 1 ise eğer admin 2 ise personel
            //querry clasımın içinde giris fonksiyonuma verileri gönderip gelen sonuca göre kontrol yapıyorum.
            int sonuc = querry.Giris(new Models.girisBilgiModel(textBox1.Text, textBox2.Text, -1,-1));
            if (sonuc == 1 || sonuc == 2)
            {
                Forms.Menu menu = new Forms.Menu(this, sonuc);
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Parola Yanlış  Tekrar Deneyin", "Hatalı Kullanıcı Girişi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
