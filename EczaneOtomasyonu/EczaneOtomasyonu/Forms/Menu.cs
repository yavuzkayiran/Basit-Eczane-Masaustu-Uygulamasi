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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
     
        public Menu(Form Giris, int sonuc)
        {
            InitializeComponent();
            if (sonuc == 2)
            {
                button5.Enabled = false;
            }

        }
        // Menu içerisinde gereken sayfalara yönlendirme yapıyorum.

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelKayit personeKayit = new PersonelKayit();
            personeKayit.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IlacBilgi ilacBilgi = new IlacBilgi();
            ilacBilgi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaKayit hastaKayit = new HastaKayit();
            hastaKayit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IlacSatis ilacSatis = new IlacSatis();
            ilacSatis.ShowDialog();
        }
    }
}
