using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcıdan Sayı İsteyelim : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kullanıcıdan Sayı İsteyelim : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            ToplamaYap(sayi, sayi2);
            
            
            int toplam=ToplamaYap2(sayi, sayi2);
            Console.WriteLine(toplam);
        }

        //Geriye Değer Döndürmeyen
       static void ToplamaYap(int birincisayi,int ikincisayi)
        {
            int toplam = birincisayi + ikincisayi;
            Console.WriteLine(toplam);
        }

        //Geriye Değer Döndüren Metot
        static int ToplamaYap2(int birincisayi,int ikincisayi)
        {
            return birincisayi + ikincisayi;
        }
    }
}
