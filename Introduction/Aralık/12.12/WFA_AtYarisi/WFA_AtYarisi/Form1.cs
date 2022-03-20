using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();


        private void Form1_Load(object sender, EventArgs e)
        {
            pbBirinciAt.Left = pbIkinciAt.Left = pbUcuncuAt.Left = pbDorduncuAt.Left = 5;
        }

        private void btnYarisiBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbBirinciAt.Location = new Point(pbBirinciAt.Location.X + rnd.Next(10, 20), pbBirinciAt.Location.Y);
            //pbBirinciAt.Left += rnd.Next(10, 20);
            pbIkinciAt.Left += rnd.Next(10, 20);
            pbUcuncuAt.Left += rnd.Next(10, 20);
            pbDorduncuAt.Left += rnd.Next(10, 20);

            if (pbBirinciAt.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Birinci At Kazandı", "Yarış Bitti ve Kazanan...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pbIkinciAt.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("İkinci At Kazandı", "Yarış Bitti ve Kazanan...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(pbUcuncuAt.Left+pbUcuncuAt.Width>=lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Ucuncu At Kazandı", "Yarış Bitti ve Kazanan...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pbDorduncuAt.Left+pbDorduncuAt.Width>=lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Dördüncü At Kazandı","Yarış Bitti ve Kazanan...",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            //if (timer1.Enabled==false)
            //{

            //}
            if (!timer1.Enabled)//true değilse
            {
              DialogResult cvp=  MessageBox.Show("Tekrar Oynamak İster misiniz?","Oyun Sonu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (cvp==DialogResult.Yes)
                {
                    
                    pbBirinciAt.Left = pbIkinciAt.Left = pbUcuncuAt.Left = pbDorduncuAt.Left = 5;
                }
                else
                {
                    Application.Exit();
                }
            }

        }

      
    }
}
