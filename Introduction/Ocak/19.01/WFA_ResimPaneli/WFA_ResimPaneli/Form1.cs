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

        Image ResimGetir(string name)
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(name);
        }

        void PictureBoxaResimAta(PictureBox pb,string resimAdi)
        {
            pb.Image = ResimGetir(resimAdi);
            pb.Tag=resimAdi;
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            //Bu Evetn form üzerindeki hangi nesneye basıldı da çalıştı? => sender parametresinde
            if (!(sender is Button))
            {
                return;
            }

            Button tiklanan = sender as Button;
            #region Metot Kullanmadan Önce
            //int hangiresim = (int)tiklanan.Tag;
            //pbResim.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{hangiresim}");
            //pbResim.Image.Tag = hangiresim; 
            #endregion

            string hangiresim = tiklanan.Tag.ToString();
            PictureBoxaResimAta(pbResim, hangiresim);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResimleriEkle();
        }

        private void btnIlk_Click(object sender, EventArgs e)
        {
            #region Metot Kullanmadan Önce
            //pbResim.Image = (Image)Properties.Resources.ResourceManager.GetObject("1");
            //pbResim.Image.Tag = 1; 
            #endregion

            PictureBoxaResimAta(pbResim, "1");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
           
            if (btnIleri.Enabled==false)
            {
                btnIleri.Enabled = true;
            }

            if (pbResim.Image==null)
            {
                MessageBox.Show("Önce Bir Resim Seçiniz");
                return;
            }

            int resimsirasi=(int)pbResim.Image.Tag;
            resimsirasi--;
            if (resimsirasi>0)
            {
                //pbResim.Image = (Image)Properties.Resources.ResourceManager.GetObject(resimsirasi.ToString());
                //pbResim.Image.Tag = resimsirasi;
                PictureBoxaResimAta(pbResim, resimsirasi.ToString());
            }
            else
            {
                btnGeri.Enabled = false;
            }


        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (btnGeri.Enabled==false)
            {
                btnGeri.Enabled = true;
            }
            
            if (pbResim.Image == null)
            {
                MessageBox.Show("Önce Bir Resim Seçiniz");
                return;
            }
            //Resources dosyasında kaç resim var
            string[] resimadları=  System.IO.Directory.GetFiles(@"..\..\Resources");
            int resimsirasi = (int)pbResim.Image.Tag;
            resimsirasi++;
            if (resimsirasi <= resimadları.Length)
            {
                //pbResim.Image = (Image)Properties.Resources.ResourceManager.GetObject(resimsirasi.ToString());
                //pbResim.Image.Tag = resimsirasi;

                PictureBoxaResimAta(pbResim, resimsirasi.ToString());
            }
            else
            {
                btnIleri.Enabled = false;
            }

        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            #region Metot Kullanmadan Önce
            //pbResim.Image = (Image)Properties.Resources.ResourceManager.GetObject("24");
            //pbResim.Image.Tag = 24; 
            #endregion
            PictureBoxaResimAta(pbResim, "24");
            //Gözdenin sorusunun cevabı(soru: tüm resimlere nasıl ulaşırız.)
            //string[] resimadları=  System.IO.Directory.GetFiles(@"..\..\Resources");

        }

        Random rnd = new Random();
        private void btnRastgele_Click(object sender, EventArgs e)
        {
            int rastgeleSayi = rnd.Next(1, 25);
            pbResim.Image = (Image)Properties.Resources.ResourceManager.GetObject(rastgeleSayi.ToString());
            pbResim.Image.Tag = rastgeleSayi;

        }

        private void btnSlayt_Click(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pbResim.Size = new Size(this.Width, this.Height);
            pbResim.Location = new Point(0, 0);
            foreach (Control item in this.Controls)
            {
                if (!(item is PictureBox))
                {
                    item.Visible = false;
                }
            }
            timer1.Enabled = true;
        }
        int sira = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sira++;
            PictureBoxaResimAta(pbResim, sira.ToString());
            if (sira>24)
            {
                sira = 0;
            }
        }
    }
}
