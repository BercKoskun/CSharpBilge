using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            try
            {
               int sayi= Convert.ToInt32(txtSayi.Text);
                if (sayi%2==0)
                {
                    MessageBox.Show("Sayı Çifttir.");
                }
                else
                {
                    MessageBox.Show("Sayi Tektir.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Girmiş olduğunuz deger sayi değildir!!!\n{ex.Message}");
            }
        }
    }
}
