using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_IcIceDongu
{
    class Program
    {
        static void Main(string[] args)
        {

            //iç içe döngü, dış döngünün her bir adımı için iç döngü tamamen çalışır.
            // 1 den 5 ekadar olan dış döngü için her bir adımda 10 kere ekrana aynı sayıyı yazmak isterseniz aşağıdaki kodu uygularsınız.
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //}

            //1 den 10 a kadar olan asal sayılar
            
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i==1)
            //    {
            //        Console.WriteLine($"Sayı Asal Değildir => {i}");
            //        //i++;
            //        continue;//döngüde bir sonraki adıma geçer ve kendinden sonraki kodların çalışmasını engeller.
            //    }

            //    int bolunmesayisi = 0;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i%j==0)
            //        {
            //            bolunmesayisi++;
            //            break;//mevcut bulunduğu döngüyü bitirir.
            //        }
            //    }

            //    if (bolunmesayisi==0)
            //    {
            //        Console.WriteLine($"Sayı Asaldır => {i}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Sayı Asal Değildir => {i}");
            //    }
            //}



            //İçi dolu kare
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********

            for (int i = 0; i < 10; i++)//Satır
            {

                for (int j = 0; j < 10; j++)//Sutun
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }

            //////////Ödev /////////////////////////
            //içi boş kare
            // **********
            // *        *
            // *        *
            // *        *
            // *        *
            // *        *
            // **********

            //içi boş köşegenli kare
            // ***********
            // **       **
            // *  *   *  *
            // *    *    *
            // *  *   *  *
            // **       **
            // ***********

            //Mektıp zarfı
            // ***********
            // **       **
            // *  *   *  *
            // *    *    *
            // *         *
            // *         *
            // ***********

            //Baklava Dilimi
            /*
                    *
                   * *
                  * * *
                 * * * *
                  * * *
                   * *
                    * 
             */

        }
    }
}
