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
        
        int sayi = 0;
        private void btnEksi_Click(object sender, EventArgs e)
        {
           
            sayi--;
            lblSonuc.Text = sayi.ToString();

        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            sayi++;
            lblSonuc.Text = sayi.ToString();
        }





    }
}
