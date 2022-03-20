using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_SayilariSirala
{
    class Program
    {

        /*
         Matıksal Operatorler
           & -> ve / tüm koşullar true dönmesi gerekir.
           | -> veya koşullardan her hangi biri true dönmesi gerekir. 
         
         */

        static void Main(string[] args)
        {
            int a = 10, b = 54, c = 64;
            if (a>b & b>c)
            {
                Console.WriteLine($"{a}>{b}>{c}");
            }
            else if(a>c & c>b)
            {
                Console.WriteLine($"{a}>{c}>{b}");
            }
            else if(b>a & a>c)
            {
                Console.WriteLine($"{b}>{a}>{c}");

            }
            else if(b>c & c>a)
            {
                Console.WriteLine($"{b}>{c}>{a}");
            }
            else if(c>a & a>b)
            {
                Console.WriteLine($"{c}>{a}>{b}");
            }
            else if(c>b&b>a)
            {
                Console.WriteLine($"{c}>{b}>{a}");
            }
            else
            {
                Console.WriteLine("Bir Eşitlik Durumu Söz Konusu");
            }

        }
    }
}
