using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ButtonYakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }


        Random rnd = new Random();
        private void btnYakala_MouseEnter(object sender, EventArgs e)
        {
            int formgenislikdegeri = this.Width-btnYakala.Width-50;
            int formyukseklikdegeri = this.Height-btnYakala.Height-50;
            btnYakala.Left = rnd.Next(0,formgenislikdegeri);
            btnYakala.Top = rnd.Next(0,formyukseklikdegeri);
        }
        private void btnYakala_Click(object sender, EventArgs e)
        {
            sayac++;
            MessageBox.Show($"Tebrikler {sayac}. Tıklamada Kazandınız");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //sadece form yüklenirken çalışır.
        }
        int sayac = 0;
        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = (++sayac).ToString();
        }
    }
}
