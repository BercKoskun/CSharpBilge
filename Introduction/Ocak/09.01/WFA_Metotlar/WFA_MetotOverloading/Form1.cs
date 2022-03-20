using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MetotOverloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Topla(12, 21);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Topla(12, 21,45);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Topla(12, 21,45,66);
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Topla(12, 21, 45, 66,78);
          
        }

       

        /// <summary>
        /// İki Sayının Toplamını Dönen Metot
        /// </summary>
        /// <param name="sayi">birinci sayi</param>
        /// <param name="sayi2">ikinci sayi</param>
        /// <returns></returns>
        int Topla(int sayi,int sayi2)
        {
            return sayi+sayi2;
        }


        /// <summary>
        /// Üç Sayının Toplamını Dönen Metot
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        /// <param name="sayi3"></param>
        /// <returns></returns>
        int Topla(int sayi, int sayi2,int sayi3)
        {
            return sayi + sayi2+sayi3;
        }

        /// <summary>
        /// Dört Sayının Toplamını Dönene Metot
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        /// <param name="sayi3"></param>
        /// <param name="sayi4"></param>
        /// <returns></returns>
        int Topla(int sayi, int sayi2,int sayi3,int sayi4)
        {
            return sayi + sayi2 + sayi3 + sayi4;
        }

        /// <summary>
        /// Beş Sayının Toplamını Dönen Metot
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        /// <param name="sayi3"></param>
        /// <param name="sayi4"></param>
        /// <param name="sayi5"></param>
        /// <returns></returns>
        int Topla(int sayi, int sayi2, int sayi3, int sayi4,int sayi5)
        {
            return sayi + sayi2 + sayi3 + sayi4 + sayi5;
        }
        

        
    }
}
