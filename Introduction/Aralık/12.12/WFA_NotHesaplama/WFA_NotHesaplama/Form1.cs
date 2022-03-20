using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal sonuc = nudBirinciVize.Value * 0.2m + nudIkinciVize.Value * 0.2m + nudFinal.Value * 0.6m;
            lblSonuc.Text = sonuc.ToString();
            if (sonuc>=55)
            {
                lblDurum.Text = "Geçtiniz";
                lblDurum.BackColor = Color.Green;
                lblDurum.ForeColor = Color.White;
                pbDurum.Image = Image.FromFile("../../images/ok.png");
                //pbDurum.Image = Properties.Resources.cancel;
            }
            else
            {
                lblDurum.Text = "Kaldınız";
                lblDurum.BackColor = Color.DarkRed;
                lblDurum.ForeColor = Color.White;
                //pbDurum.Image = Image.FromFile("../../images/cancel.png");
                pbDurum.Image = Properties.Resources.cancel;
            }

        }
    }
}
