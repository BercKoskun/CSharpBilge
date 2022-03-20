using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           lblMayinSayisi.Text= TarlayiOlustur().ToString();
            ResimDegistir(Properties.Resources.before_mine);
        }

        int TarlayiOlustur()
        {
            int sayac = 0;
            Random rnd = new Random();
            for (int i = 1; i <= 100; i++)
            {
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;
                btn.Click += Btn_Click;
                if (rnd.Next(7,39)*i%7==0)
                {
                    btn.Tag = true;
                    sayac++;//Mayın Sayısı
                }
                flpTarla.Controls.Add(btn);
            }

            return sayac;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag!=null)
            {
                ResimDegistir(Properties.Resources.after_mine);

                foreach (Button item in flpTarla.Controls)
                {
                    if (item.Tag != null)
                    {
                        item.Enabled = false;
                        item.BackColor = Color.Red;
                        item.BackgroundImage = Properties.Resources.mines;
                        item.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        item.Enabled = false;
                        item.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                btn.Enabled = false;
                btn.BackColor = Color.Green;
            }
        }

        private void ResimDegistir(Image resim)
        {
            btnBasla.BackgroundImage = resim;
            btnBasla.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            flpTarla.Controls.Clear();
            lblMayinSayisi.Text = TarlayiOlustur().ToString();
            ResimDegistir(Properties.Resources.before_mine);
        }
    }
}
