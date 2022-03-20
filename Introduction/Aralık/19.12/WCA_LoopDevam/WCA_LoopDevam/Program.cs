using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_LoopDevam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Döngüler tekrar eden kod parcacıklarımızı çalıştırmak için kullandığımız araçlardır.
            //Döngüler bir işi yapmaya başladıklarında durana kadar sonuç üretmezler. Console uygulamalarını hariç tutuyoruz ama bunun sebebi döngülerden kaynaklı değil.

            // 4 adet döngümüz var, 
            /*
              for -> belirli adımda tekrar eden işler için kullanılır.
              while -> koşul sağlandığı sürece çalışan.
              do while -> çalışması while ile aynı ama döngü için yazılan kod bir kere çalıştırılır. Normalde döngüler koşul sağlanmadığı anda çalışmayacağı için döngü içerisinde ki kodlar çalıştırılmaz. Do while her halükarda döngü için yazılan kod parçasını bir kere çalıştırır.
              foreach -> koleksiyon(aynı tipde birden fazla veri) nesneleri için kullanılan tek yönde yani 0 noktasından koleksiyonun son elemanına doğru hareket eden nesnmizdir.

             */

            string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Bursa", "Kayseri", "Trabzon" };

            //dizinin elemanlarını ekrana yazdırma
            int dizininelemansayisi = sehirler.Length;
            for (int i = 0; i < dizininelemansayisi; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //While
            int indexno = 0;
            while(indexno<dizininelemansayisi)
            {
                Console.WriteLine(sehirler[indexno]);
                indexno++;
               
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //do while
            int sirano = 0;
            do
            {
                Console.WriteLine(sehirler[sirano]);
                sirano++;
            }
            while (sirano < dizininelemansayisi);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // foreach -> sadece koleksiyon nesneleri ile kullanılır.
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            //birden 100 e kadar olan sayıların toplamını ekrana yazdıran program.
            Console.Clear();
            int toplam = 0;
            for (int i = 0; i <= 100; i++)
            {
                toplam += i;

            }
            Console.WriteLine($" Birden Yüze kadar olan sayıların toplamı => {toplam}");
            //birden 100 e kadar tek ve çift sayıların ayrı toplamını ekrana yazdıran program.
            int cifttoplam = 0;
            int tektoplam = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i%2==0)
                {
                    cifttoplam += i;
                }
                else
                {
                    tektoplam += i;
                }
            }
            Console.WriteLine($"Tek Sayıların Toplamı=>{tektoplam}");
            Console.WriteLine($"Çift Sayıların Toplamı=>{cifttoplam}");


            //girilen sayının asal olup olmadığını bulan programı yapınız.
            #region Asal Olup Olmadığını Bulan Program
            //Console.Write("Kontrol Edilecek Sayıyı Gir :  ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int bolunmesayisi = 0;

            //if (sayi<2)
            //{
            //    Console.WriteLine("Asal Sayı Değildir.");
            //}
            //else
            //{
            //    for (int i = 2; i <= sayi / 2; i++)
            //    {


            //        if (sayi % i == 0)
            //        {
            //            bolunmesayisi++;
            //        }
            //    }

            //    if (bolunmesayisi == 0)
            //    {
            //        Console.WriteLine("Sayı Asaldır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Asal Sayı Değildir.");
            //    }
            //} 
            #endregion
            do
            {
                Console.Write("Kontrol Edilecek Sayıyı Gir :  ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int bolunmesayisi = 0;

                if (sayi < 2)
                {
                    Console.WriteLine("Asal Sayı Değildir.");
                }
                else
                {
                    for (int i = 2; i <= sayi / 2; i++)
                    {


                        if (sayi % i == 0)
                        {
                            bolunmesayisi++;
                        }
                    }

                    if (bolunmesayisi == 0)
                    {
                        Console.WriteLine("Sayı Asaldır.");
                    }
                    else
                    {
                        Console.WriteLine("Asal Sayı Değildir.");
                    }
                }

                Console.WriteLine("Yeni bir sorgulama yapmak istiyor musunuz ? E\\H ");
                string tus = Console.ReadLine();
                if (tus!="E")
                {
                    Environment.Exit(0);
                }
            } while (true);

            

        }
    }
}
