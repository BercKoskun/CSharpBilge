using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ResimPaneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ResimleriEkle()
        {
            for (int i = 1; i < 25; i++)
            {
                //Runtime control
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;
                //btn.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"_{i}") as Image;
                btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"{i}");
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Tag = i;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
                
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //Bu Evetn form üzerindeki hangi nesneye basıldı da çalıştı? => sender parametresinde
            if (!(sender is Button))
            {
                return;
            }

            Button tiklanan = sender as Button;
            int hangiresim = (int)tiklanan.Tag;
            pbResim.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{hangiresim}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResimleriEkle();
        }

        private void btnIlk_Click(object sender, EventArgs e)
        {

        }
    }
}
