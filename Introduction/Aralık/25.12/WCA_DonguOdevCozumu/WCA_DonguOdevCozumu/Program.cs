using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_DonguOdevCozumu
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////Ödev /////////////////////////
            //içi boş kare
            // **********
            // *        *
            // *        *
            // *        *
            // *        *
            // *        *
            // **********

            #region İçi boş Karenin çözümü
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (i == 0 || i == 9 || j == 0 || j == 9)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }

            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            //içi boş köşegenli kare
            // ***********
            // **       **
            // *  *   *  *
            // *    *    *
            // *  *   *  *
            // **       **
            // ***********
            #region içi boş koşegenli kare nin çözümü
            //int kenaruzunlugu = 10;
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        if (i == 1 || i == kenaruzunlugu || j == 1 || j == kenaruzunlugu || i==j || i+j==kenaruzunlugu+1)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }

            //    }
            //    Console.WriteLine();
            //} 
            #endregion


            //Mektıp zarfı
            // ***********
            // **       **
            // *  *   *  *
            // *    *    *
            // *         *
            // *         *
            // ***********
            #region Mektup Zarfı Çözümü
            //int kenaruzunlugu = 10;
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        if (i == 1 || i == kenaruzunlugu || j == 1 || j == kenaruzunlugu || (i == j && i<6) || (i + j == kenaruzunlugu + 1 && i<6))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }

            //    }
            //    Console.WriteLine();
            //} 
            #endregion

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
            #region Baklava Dilimi Çözümü (Gözde)
            //int yıldızsayisi = 5;

            //for (int i = 0; i < yıldızsayisi; i++)
            //{
            //    for (int j = yıldızsayisi; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < yıldızsayisi; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = yıldızsayisi; j > i; j--)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Baklava Dilimi (anonim)
            int boyut, bosluksayisi, yildizsayisi;

            boyut = 10;
            if (boyut % 2 == 0)
                boyut++;
            bosluksayisi = boyut / 2;
            yildizsayisi = 1;
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < bosluksayisi; j++)
                    Console.Write(" ");

                for (int j = 0; j < yildizsayisi; j++)
                    Console.Write("* ");


                if (i < boyut / 2)
                {
                    bosluksayisi--;
                    yildizsayisi += 1;
                }
                else
                {
                    bosluksayisi++;
                    yildizsayisi -= 1;
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}
