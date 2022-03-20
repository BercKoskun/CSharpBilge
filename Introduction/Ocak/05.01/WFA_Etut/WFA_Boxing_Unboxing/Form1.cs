using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Boxing_Unboxing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //object => .Net teknolojisinde temeli ifade eder(Adem-Havva)

        private void Form1_Load(object sender, EventArgs e)
        {
            //int sayi = 1;
            //string kelime = "Merhaba";
            //char karakter = 'E';
            //bool dogrumu = false;

            object sayi = 1;
            object kelime = "Merhaba";
            object karakter = 'E';
            object dogrumu = false;

            int[] sayilarlistesi = { 123, 12, 12, 32, 543, 65, 76 };
            object[] degerler = { "Merhaba", 12, 13.4f, true, 'E' }; //Boxing

            string kelime2 = degerler[0].ToString();//Unboxing

            string kelime3 = kelime.ToString();

            //ListBox ve ComboBox gibi kontroller bize birden fazla farklı tipte veri saklama imkanı sunabilmek için her bir item yani içinde gösterdiği satır ya da eleman olarak düşünebiliriz, object olarak saklar. 
                //Object bir nesnenin atasıdır. tüm nesneler object sınıfından türer.
        }
    }
}
