using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MasaUstuUygulamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Bir eventi yanlislikla tetiklediyseniz, yapmaniz gereken sey, ilgili kontrolun "events" sekmesine gelerek tetiklenmis olan olaya sag tik => Reset secenegini secmenizdir. Boylece saglikli bir sifirlama islemine imza atmis olursunuz...
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int textkutusuharfsayisi = txtHarfKutusu.Text.Length;
            int karakterhesapla =280 - textkutusuharfsayisi;
            //lblHarfSayisi.Text =Convert.ToString( karakterhesapla);
            lblHarfSayisi.Text =karakterhesapla.ToString();
        }

        
    }
}
