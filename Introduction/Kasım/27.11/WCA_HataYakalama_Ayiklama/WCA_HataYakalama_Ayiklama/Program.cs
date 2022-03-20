using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_HataYakalama_Ayiklama
{
    class Program
    {/*
         1)  Derleme Zamanı Hataları (Compile Time Exception) => 
             * Yazım kurallarimizda, soz dizimizde (syntax) gerceklesmis olan hatalara derleme zamani hatalari denir. 
             * Ornegin, kod satirinda noktali virgul'un olmaması, ozelligi atama yaparken atama operatorunun kullanilmamasi gibi. En kolay bulunabilir hatalardir. 
             * Bu konuda Visual Studio size "Error List" penceresi yardımıyla hatalari raporlar ve cift tikladiginiz anda sizi hatanin bulundugu satira gonderir...
             * 
         2)  Çalışma Zamanı Hataları (Runtime Exception) => 
             * Bir diger deyisle kullanici kaynakli hatalardir. 
             * Sayi girilmesi gereken bir alana metin girilmesi gibi. Bu yazilimci tarafindan ongorulmesi gereken bir hata turudur. 
             * Yazilimciya dusen sey ise, hata alma riski bulunan kodlari hata yonetimi cercevesinde ele almaktir. 
             * 
         3)  Mantıksal Hatalar => Yuzde yuz yazilimci hatasidir. 
             * KDV hesaplayan bir uygulamada carpilan degeri 1.18 yerine 0.18 girilmesi gibi.. 
             * Cozulmesi en zor hata tipidir. Yapmaniz gereken sey islem butunlugu tum kodlarinizi tek tek okumaktir.breakpoint,immediatly watch,quick,
         * 
         */
        static void Main(string[] args)
        {
            #region Derleme Hatası
            //int sayi ="" ; //derleme hatası -> int yani tamsayısal veri tipine string(metin) ifadesi atanmaya çalışılıyor. bu yüzden error list ekranında yapılan hatanın açıklamasını takip edebiliriz. Derleme hataları programın derlemesini engellediği için çalıştırırken size bir uyarı gönderir.
            //Console.Write(sayi);

            #endregion
            try
            {
                Console.Write("Bir Sayı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Girmiş olduğunuz sayı : {sayi}");
            }
            catch
            {
                Console.WriteLine("Bir Hata Meydana Geldi");
            }

            Console.ReadLine();

            // Ödev -> girilen bilginin Rakam ya da metinsel ifade olduğunu bulan  ve değerleri açıklaması ile gösteren programı yazınız
        }

        
    }
}
