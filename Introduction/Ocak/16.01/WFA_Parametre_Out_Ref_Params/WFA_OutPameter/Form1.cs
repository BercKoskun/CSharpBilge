using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OutPameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int outislemsonucu;
            int outcarpmaislemisonucu;

            int islemsonucu=1;
            int carpmaislemisonucu=1;

            ToplamaIslemi(12, 12,islemsonucu,carpmaislemisonucu);

            ToplamaIslemi(12, 12,out outislemsonucu,out outcarpmaislemisonucu);
            lblOutDeger.Text = islemsonucu.ToString();
            MessageBox.Show(carpmaislemisonucu.ToString());
            lblReturn.Text= ToplamaIslemi(12, 12).ToString();
        }
        void ToplamaIslemi(int birincisayi, int ikincisayi,  int toplamasonucu,  int carpmasonucu)
        {
            toplamasonucu = birincisayi + ikincisayi;
            carpmasonucu = birincisayi * ikincisayi;
        }
        /*
      * OUT ANAHTAR KELİMESİ
      * Bir metot icerisinden disariya birden fazla deger dondurmek isterseniz, "return" anahtar kelimesi fonksiyonlarda size yetmeyecektir. Void metotlar ise zaten geriye deger dondurmez. Bu bilinenleri yikabilmek icin kullandigimiz anahtar kelime "out" anahtar kelimesidir...
      */
        void ToplamaIslemi(int birincisayi,int ikincisayi,out int toplamasonucu,out int carpmasonucu)
        {
            toplamasonucu= birincisayi + ikincisayi;
            carpmasonucu = birincisayi * ikincisayi;
        }

        int ToplamaIslemi(int birincisayi,int ikincisayi)
        {
            return birincisayi + ikincisayi;
        }
    }
}
