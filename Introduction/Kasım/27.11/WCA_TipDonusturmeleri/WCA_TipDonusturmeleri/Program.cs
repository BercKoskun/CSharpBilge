using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_TipDonusturmeleri
{
    class Program
    {
        /*
          kod ekranının varsayılan tamsayısal veritipi int32(int), ondalıksal veritipi ise double
         ondalıksal verileri yazarken "." kullanırız. form ekranlarında ise "," kullanılır.
         */
        static void Main(string[] args)
        {
            #region Kapalı Tip Dönüşüm (Implicit Conversion)
            //int tamsayi = 15;
            //float sayi = tamsayi;
            //long buyuktamsayi = long.MaxValue;
            //sayi = buyuktamsayi;
            //sayi=15.2f; 
            //byte sayi = 25;
            //short sayi2 = sayi;
            //int sayi3 = sayi2;
            //long sayi4 = sayi3;
            //-------------------------------------------
            //float sayi5 = sayi4;
            //double sayi6 = sayi5;
            //decimal sayi7 = sayi6; decimal ram de daha fazla yer kaplasada max-min değer aralığı double dan büyük değildir. bu yüzden double kapalı tip ile dönüştürülemez.

            //Suffix -> ek ad olarak tanımlayabiliriz. float ve decimal değişkenlere değer ataması yaparken sayının nasıl davranması gerektiğini veririz.
            //ondalıksal veritiplerine değer ataması yapılırken değişken kullanılmıyorsa double en büyük ondalıksal veri tipi olduğundan float için f, decimal için m suffix'i kullanılır. 
            //Değişken kullanılıyorsa Convert işlemleri yapmak gerekir.
            //Convert sınıfı ile
            //Parse Metodu ile
            //casting ile

            //float f = 15.2f;
            //decimal m = 15.2m;
            //double d = 15.2;

            #endregion

            #region Veritiplerinde artimetik işlemlerde özel durum
            //int birincisayi = int.MaxValue;
            //int ikincisayi = int.MaxValue;
            //int toplam = birincisayi + ikincisayi;
            //Console.WriteLine(toplam);
            //long birincisayi2 = 556565;
            //long ikincisayi2 = 6767;
            //long toplam2 = birincisayi2 + ikincisayi2;
            //Console.WriteLine(toplam2);
            // iki ya da daha fazla int ve ya long değişkeni toplarken sonucun atamasını yine int veya long veritipinde ki bir değişkene yapabilirim. fakar byte ve short için aynı durum söz konusu değildir. bu veritipleri kendi aralarında toplandıklarında sonuc her zaman int veri tipine dönüştürülür ve atanır. 

            //byte bytesayi = 0;
            //byte bytesayi2 = 0;
            //int bytetoplam = bytesayi + bytesayi2;

            //short shortsayi = 0;
            //short shortsayi2 = 0;
            //int shortToplam = shortsayi + shortsayi2;

            #endregion

            #region Açık tip Dönüşüm (Explicit Converison)
              // Convert sınıfı metotları
                   //bir veri tipini diğer veritiplerine dönüştüren metotların saklandığı alana verilen addır. 
                   //Convert dönüştürme işlemini yaparken sadece veritiplerine ait değerleri dönüştürür. değişkenin program içerisinde ki veri tipini dönüştürmez.

            int sayi =15;
            short sayi2 = 0;
            sayi2 = Convert.ToInt16(sayi);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi.GetType().Name);//sayi değişkenin veritipini ekrana yazdırdık ve gördük ki dönüştürme metodu kesinlikle veritipine müdahale edemiyor.

            //--------------------------------------------------------
            // Parse metodu -> sadece string veritipine ait değerkeri diğer veri tiplerine döndürür.
            string tcKimlikno = "12345678901";
            int rakamsalTcKimlikNo = int.Parse(tcKimlikno);
            // ToString Metodu
            // bilgisayar ekranlarının aldığı ya da veridiği değerler metinsel veritiplerinden string olduğu için burada geliştiriciler bu işlemi hızlıca yapabilmek adına ToString metodunu tanımlamışlardır. her bir değişkenin adı.ToString() metodu kullanımı ile string'e hızlıca dönüştürülmes sağlanır.
            string yenitckimlikno = rakamsalTcKimlikNo.ToString();

            #endregion

        }
    }
}
