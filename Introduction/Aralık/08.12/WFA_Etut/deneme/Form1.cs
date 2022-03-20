using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Etut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnEksi_Click(object sender, EventArgs e)
        {
            int sayi=0;
            sayi--;
            txtSayi.Text = sayi.ToString();
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            sayi++;
            txtSayi.Text = sayi.ToString();
        }
        int globalSayi = 0;
        private void btnGlonalEksi_Click(object sender, EventArgs e)
        {
            globalSayi--;
            txtGlobalText.Text = globalSayi.ToString();
        }
        
        private void btnGlobalArti_Click(object sender, EventArgs e)
        {
            globalSayi++;
            txtGlobalText.Text = globalSayi.ToString();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
          int  inputDeger = Convert.ToInt32(textBox1.Text);
            inputDeger--;
            textBox1.Text = inputDeger.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int inputDeger = Convert.ToInt32(textBox1.Text);
            inputDeger++;
            textBox1.Text = inputDeger.ToString();
        }
    }
}
