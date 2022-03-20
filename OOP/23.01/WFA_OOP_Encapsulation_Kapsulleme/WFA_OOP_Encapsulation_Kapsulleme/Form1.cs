using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOP_Encapsulation_Kapsulleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Insan insan = new Insan();
                insan.Ad = txtAd.Text;
                insan.Soyad = txtSoyad.Text;
                insan.TcKimlikNo = txtTCKimlikNo.Text;
                MessageBox.Show("Kişi Veri Tabanına Eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtAd.Text = string.Empty;
                txtSoyad.Text = string.Empty;
                txtTCKimlikNo.Text = string.Empty;
            }
        }
    }
}
