using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_Loop_Dnguler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //başlangıç ve bitiş koşulları belirli olan işlemlerde kullanırız.
            //1999 yılından 2021 yılına kadar olan yılları ekranda gösterin.
            //int baslangic = 1997;
            //int bitisdegerim = 2021;

            //for(int i=baslangic;i<=2021;i++)
            //{

            //    //Console.WriteLine($"Yıl : {i}");
            //    Console.WriteLine($"Yıl : {baslangic++}");

            //}
            #endregion

            #region While Döngüsü
            //koşulunuz sağlandığı sürece çalışmasını istediğiniz kodları çalıştıran nesne.
            //DateTime cikisSaati = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 56, 0);
            //int i = 0;
            //while(DateTime.Now<cikisSaati)
            //{

            //    Console.WriteLine(i++);

            //}
            //int i = 0;
            //bool mesaisaati = true;
            //while(mesaisaati)
            //{
            //    Console.WriteLine(i++);
            //    if (DateTime.Now.Hour>=13&& DateTime.Now.Minute>=59)
            //    {
            //        mesaisaati = false;
            //    }
            //}

            #endregion

            #region Do-While
            //string kadi = "admin";
            //string sifre = "123";
            //string gkadi = "";
            //string gsifre = "";
            //do
            //{
            //    Console.Write("Kullanıcı Adı : ");
            //    gkadi = Console.ReadLine();
            //    Console.Write("Şifre : ");
            //    gsifre = Console.ReadLine();

            //}
            //while (gkadi != kadi || gsifre != sifre);
            //Console.WriteLine("Hoşgeldin Admin");
            #endregion

            #region ForEach
            //Koleksiyon nesnelerinde ki elemanları 0.sıradan itibaren belirlenen iterasyon değişkenine atamasını yapar ve bize teslim eder. 
            //sadece iler yönlü işlem yapabildiği için kullanımı güvenlidir. aynı zamanda iterasyon değişkenin değerini değiştirmenize izin vermez. bu da veri güvenliği sağlar.
            //string[] isimler = { "Kürşat", "Bora", "Rüstem", "Fatih", "Emre", "Cemil", "Rıdvan" };

            //foreach (string isim in isimler)
            //{
            //    //isim = "Ayşegül";
            //    Console.WriteLine(isim);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //// For - ForEach farkı for bize dizinin elemanlarını değiştirme imakanı verirken Foreach bunu engeller.
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    isimler[i] = "Ayşegül";
            //    Console.WriteLine(isimler[i]);
            //}
            #endregion

            #region For ile sonsuz döngü
            Random rnd = new Random();
            //for (; ; )
            //{
            //    //Sonsuz Döngü
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //    Console.Write(rnd.Next(0,10));
            //}

            //for (int i = 0; i < 1;)
            //{
            //    //Sonsuz Döngü
            //    Console.Write(rnd.Next(0, 10));

            //}
            #endregion

            string kelime = "Rıdvan";
            //string aslında char dizidir. sözünde şairin anlatmak istediği nedir? araştırınız.
            #region for ile ters döngü
            for (int i = kelime.Length; i >0; i--)
            {
                Console.Write(kelime[i-1]);
            }
            #endregion
        }
    }
}
