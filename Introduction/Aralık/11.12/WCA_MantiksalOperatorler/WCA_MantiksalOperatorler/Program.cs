using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_MantiksalOperatorler
{
    class Program
    {

        /*
         Matıksal Operatörler
          & -> ve /tüm koşulların doğru olması beklenir
          | -> veya / tüm koşulların doğru olması beklenmez. koşullardan birinin doğru olması yeterlidir. 
         */
        static void Main(string[] args)
        {
            int gunsayisi = Convert.ToInt32(DateTime.Now.DayOfWeek);
            #region  veya mantıksal operatörü
            DayOfWeek gun = DateTime.Now.DayOfWeek; //-> Datetime => tarih saat döndüren sınıf. Now -> bu sınıf içerisinde ki şimdiki zamanı temsil eder. DayOfWeek -> şimdiki zamanda haftanın hangi günündeyiz.

            if (gun == DayOfWeek.Saturday | gun == DayOfWeek.Sunday)
            {
                Console.WriteLine("Bugün Tatil");
            }
            else if(gun == DayOfWeek.Monday | gun==DayOfWeek.Tuesday | gun==DayOfWeek.Wednesday| gun==DayOfWeek.Thursday | gun==DayOfWeek.Friday)
            {
                Console.WriteLine("Bugün İş Günü");
            }
            #endregion
        }
    }
}
