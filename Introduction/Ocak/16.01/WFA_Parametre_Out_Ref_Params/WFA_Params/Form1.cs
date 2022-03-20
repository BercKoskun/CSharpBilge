using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Params
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
           PARAMS ANAHTAR KELİMESİ
           Disaridan metoda kac parametre gelecegi bilinmemektedir. Ancak gelecek olan tum parametrelerle de bir takım işlemler yapmak zorundasınız.
           Bu sayisiz parametreyi tek bir cati altında toplamanin yolu "params" anahtar kelimesinden gecmektedir. DİKKAT: Params sizden bir dizi isteyecektir...
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] toplanacaksayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 4, 3, 24, 324, 25, 46, 5, 532, 432, 54, 45 };
            SayilariTopla(toplanacaksayilar);
           
            int sonuc = SayilariTopla("Merhaba Dünya", 1, 23, 43, 2, 3, 43, 45, 6, 67, 56, 456, 65, 65, 657, 657, 657, 7);
            MessageBox.Show(sonuc.ToString());

            int sayi1 = 1;
            int sayi2 = 2;
            int sayi3 = 3;
            SayilariTopla(sayi1, sayi2, sayi3);
        }
        int SayilariTopla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            return toplam;

        }
        int SayilariTopla(string mesaj,params int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            return toplam;

        }

       
    }
}
