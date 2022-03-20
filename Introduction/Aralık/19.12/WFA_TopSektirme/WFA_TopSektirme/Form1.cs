using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TopSektirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dyon = 5;// hem gidiş hızı hemde pozitif ve negatif değer ile formda aşağı ve yukarı hareketi belirler.
        int yyon = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            #region Odevin Doğru yapılışu
            if (pbTop.Top < 0)
            {
                dyon *= -1;
            }
            else if (pbTop.Top + pbTop.Height > this.Height)
            {
                dyon *= -1;
            }

            pbTop.Top += dyon;

            #endregion

            #region Yanlış
            //if (pbTop.Top < 0 )
            //{
            //    pbTop.Top += 5;
            //}
            //else
            //{
            //    pbTop.Top += -5;
            //}
            ////////////////////////////////////////////////////////////////////7
            //if (pbTop.Top>0 && pbTop.Top+pbTop.Height< this.Height)
            //{
            //    pbTop.Top += 5;
            //}
            //else
            //{
            //    pbTop.Top += -5;
            //}
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Bonus, hız arttırma işlemi
            //if (yon<0)
            //{
            //    yon += -5;
            //}
            //else
            //{
            //    yon += 5;
            //}
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (dyon < 0)
                    {
                        dyon += -5;
                    }
                    else
                    {
                        dyon += 5;
                    }
                    break;
              
                case Keys.D:
                    timer2.Stop();
                    timer1.Start();

                    break;
               
                case Keys.Y:
                    timer1.Stop();
                    timer2.Start();

                    break;
                case Keys.S:
                    timer1.Start();
                    timer2.Start();
                    break;
                case Keys.Z:
                    if (dyon < 0)
                    {
                        dyon += 5;
                    }
                    else
                    {
                        dyon += -5;
                    }
                    break;
                
                
                default:
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pbTop.Left < 0)
            {
                yyon *= -1;
            }
            else if (pbTop.Left + pbTop.Width > this.Width)
            {
                yyon *= -1;
            }

            pbTop.Left += yyon;
        }

       
    }
}
