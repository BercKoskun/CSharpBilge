using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            int ay = tarih.Month;

            //if (ay==1)
            //{
            //    MessageBox.Show("Mevsim Kış");
            //}
            //else if (ay == 2)
            //{
            //    MessageBox.Show("Mevsim Kış");
            //}
            //.
            //.
            //.




            #region Switch Case
            //switch (ay)
            //{
            //    case 1:
            //        MessageBox.Show("Mevsim Kış");
            //        break;
            //    case 2:
            //        MessageBox.Show("Mevsim Kış");
            //        break;
            //    case 3:
            //        MessageBox.Show("Mevsim İlkbahar");
            //        break;
            //    case 4:
            //        MessageBox.Show("Mevsim İlkbahar");
            //        break;
            //    case 5:
            //        MessageBox.Show("Mevsim İlkbahar");
            //        break;
            //    case 6:
            //        MessageBox.Show("Mevsim Yaz");
            //        break;
            //    case 7:
            //        MessageBox.Show("Mevsim Yaz");
            //        break;
            //    case 8:
            //        MessageBox.Show("Mevsim Yaz");
            //        break;
            //    case 9:
            //        MessageBox.Show("Mevsim Sonbahar");
            //        break;
            //    case 10:
            //        MessageBox.Show("Mevsim Sonbahar");
            //        break;
            //    case 11:
            //        MessageBox.Show("Mevsim Sonbahar");
            //        break;
            //    case 12:
            //        MessageBox.Show("Mevsim Kış");
            //        break;

            //} 
            #endregion


            //if (ay==1||ay==2||ay==12)
            //{
            //    MessageBox.Show("Mevsim Kış");
            //}
            //else if (ay==3||ay==4||ay==5)
            //{
            //    MessageBox.Show("Mevsim İlkbahar");
            //}
            #region Kısadevre Switch Case
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    MessageBox.Show("Mevsim Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    MessageBox.Show("Mevsim İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    MessageBox.Show("Mevsim Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    MessageBox.Show("Mevsim Sonbahar");
                    break;
               

            }
            #endregion
        }
    }
}
