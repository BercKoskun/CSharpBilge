using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_KisaDevreMantiksalOperatorler
{
    class Program
    {
        /*
         Matıksal Operatörler
         && -> kısa devre ve / koşullardan birtanesi false değer alıyorsa if bloguna giremeyeceği için geride kalan koşulları denetlemeyi bırakır.
         || -> kısa devre veya /
         */
        static void Main(string[] args)
        {
            #region Kısa Devre Ve &&
            string kullaniciadi = "ridvan";
            string sifre = "123";
            int sayac = 0;

            if ((kullaniciadi=="admin" && sifre =="123") &(++sayac)<5)
            {
                Console.WriteLine("Merhaba Admin");
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı Ya da Şifre Hatalı");
            }
            #endregion

            #region Kısa Devre Veya
            bool ogsvarmi = true;
            bool hgsvarmi = false;

            if (ogsvarmi==true || hgsvarmi==true || (++sayac)<5)
            {
                Console.WriteLine("Hızlı geçebilirsiniz.");
            }

            #endregion
            Console.ReadLine();

        }
    }
}
