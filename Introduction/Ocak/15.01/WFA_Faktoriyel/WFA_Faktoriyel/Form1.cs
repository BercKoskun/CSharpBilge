using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //5! => 1*2*3*4*5 = 120
        private void Form1_Load(object sender, EventArgs e)
        {
            //int sonuc = 1;
            //for (int i = 1; i <= 6; i++)
            //{
            //    sonuc *= i;
            //}
            //MessageBox.Show(sonuc.ToString()) ;
            MessageBox.Show( Faktoriyel(5).ToString());
        }

        int Faktoriyel(int sayi)
        {
            if (sayi==1)
            {
                return sayi;
            }
            return sayi * Faktoriyel(sayi - 1);
        }
       





    }
}
