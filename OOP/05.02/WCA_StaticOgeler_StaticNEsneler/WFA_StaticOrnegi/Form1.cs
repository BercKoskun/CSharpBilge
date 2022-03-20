using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_StaticOrnegi.Tools;
namespace WFA_StaticOrnegi
{
    //using Tools;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Firma yeniFirma = new Firma();
            yeniFirma.FirmaAdi = txtFirmaAd.Text;
            yeniFirma.VergiDairesi = txtVergiDairesi.Text;
            yeniFirma.VergiNo = txtVergiNo.Text;
            yeniFirma.FirmaEkle(yeniFirma);
            FormTools.Temizle(this.Controls);
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
           
            foreach (Firma item in Firma.Firmalar)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex<=-1)
            {
                MessageBox.Show("Seçili Firma Yok");
                return;
            }

            Firma secili = listBox1.SelectedItem as Firma;
            txtFirmaAd.Text = secili.FirmaAdi;
            txtVergiDairesi.Text = secili.VergiDairesi;
            txtVergiNo.Text = secili.VergiNo;

            MessageBox.Show($"{secili} Bilgilerinin Aktarımı Tamamlandı...");
        }
    }
}
