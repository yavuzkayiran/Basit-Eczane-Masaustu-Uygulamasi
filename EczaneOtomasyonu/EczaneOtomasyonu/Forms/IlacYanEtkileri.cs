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
    public partial class IlacYanEtkileri : Form
    {
        public IlacYanEtkileri()
        {
            InitializeComponent();
        }
        //Buradaki formumda ilacBilgi Tablomdan ilaç adı ve yan etkilerini view ile alıp gösteriyorum.
        private void IlacYanEtkileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eczaneDataSet7.IlacYanEtki' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilacYanEtkiTableAdapter.Fill(this.eczaneDataSet7.IlacYanEtki);

        }
    }
}
