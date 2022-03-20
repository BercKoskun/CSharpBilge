using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_HataAyiklama_RuntimeHataTurleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region iki int değişkenin toplamı
            //int sayi = 67657657;
            //int sayi2 = int.MaxValue;
            //int sonuc = sayi + sayi2;

            //int a = int.MaxValue + 1;

            //long l = long.MaxValue;
            //long l2 = long.MaxValue;
            //long sonuc2 = l + l2;
            // int a = int.MaxValue + 1; 
            #endregion


 

            #region Sistem Hata Yönetimi
            try
            {
                Console.WriteLine("Bir Sayı Giriniz");
                string giris= Console.ReadLine();
                int sayi = Convert.ToInt32(giris);
                int sonuc = sayi / 0;
            }
            catch(FormatException fex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Arkadaşım sana bir sayı gir dedik, programı zorlama...");
            }
            catch (OverflowException oex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Girmiş olduğun sayı değeri bizim planladığımızın çok üstünde ya da eksi yönde çok altında lütfen {int.MinValue} / {int.MaxValue} aralığında bir sayı giriniz.///{oex.Message}");
            }
            catch(Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }

            #endregion

        }
    }
}
