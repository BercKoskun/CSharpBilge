using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnZarAt_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
            sayac = 0;
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblZarBir.Text = rnd.Next(1, 7).ToString();
            lblZarIki.Text = rnd.Next(1, 7).ToString();
            sayac++;

            if (sayac==10)
            {
                timer1.Interval = 250;
            }
            else if(sayac==20)
            {
                timer1.Interval = 350;
            }
            else if(sayac==25)
            {
                timer1.Stop();
            }
        }

    }
}
