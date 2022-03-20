using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_TipDonusturme
{
    class Program
    {
        static void Main(string[] args)
        {
            //string deger = "15";

            //int degeridonustur = Convert.ToInt32(deger);

            //Console.WriteLine(deger+2);
            //Console.WriteLine(degeridonustur + 2);

            Console.Write("Birinci Sayıyı Gir: ");
            string sayi = Console.ReadLine();//Satırda kullanıcının yazdığı değeri oku ve sayi değişkenine atamasını yap.
            Console.Write("İkinci Sayıyı Gir: ");
            string sayi2 = Console.ReadLine();

            int birincisayi = Convert.ToInt32(sayi);
            int ikincisayi = Convert.ToInt32(sayi2);
            int toplam = birincisayi + ikincisayi;
            Console.WriteLine("İşleminizin sonucu = {0}", toplam);

            Console.ReadLine();
        }
    }
}
