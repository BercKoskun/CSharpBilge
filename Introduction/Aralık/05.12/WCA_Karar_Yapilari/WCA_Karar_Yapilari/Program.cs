using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_Karar_Yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program belli bir aşamada farklı yönlere ayrılması gerekiyorsa Karar yapılarına başvururuz.
            /*
               - if/else if/else

               - switch/case
             */

            // if -> bir koşulun doğru olup olmadığını kontrol eder. tek başına çalışabilir.
            // else if -> if koşulu doğru değil ve başka bir koşul kontrol edilmesi gerekiyorsa kullanılır. if olmadan çalışmaz.
            //else -> if ya da else if bloklarında ki koşulların doğru olmadığı her hangi bir durumda yapılması istenenler için çalışır.
            //trafik lambası örneği
            /*
              kırmızı -> dur
              sarı -> hazırlık
              yeşil -> geçiş
             */
            string renk = "yeşil";
            if (renk == "kırmızı")
            {
                Console.WriteLine("DUR");
            }
            else if(renk=="sarı")
            {
                Console.WriteLine("Hazırlan");
            }
            else if(renk=="yeşil")
            {
                Console.Write("Geç");
            }
            else
            {
                Console.Write("Dikkat et");
            }

            //İf tek başına kullanılır mı
            Console.WriteLine("Program Kapatılsın mı? E yazmanız yeterli");
            string cevap = Console.ReadLine();

            if (cevap=="E")
            {
                Environment.Exit(0);
            }

            /////Ödev -> 2 sayıyı büyükten küçüğe doğru sıralayınız.
            ////Ödev 2 -> 3 sayıyı büyükten küçüğe doğru sıralayınız.






        }
    }
}
