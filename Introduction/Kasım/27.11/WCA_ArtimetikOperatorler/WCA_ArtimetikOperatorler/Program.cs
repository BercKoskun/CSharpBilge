using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_ArtimetikOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aritmetik Operatörler
            /*
             +
             -
             *
             /
             % -> mod alma(bir sayının diğer sayıya bölümünden kalanı almak istediğimizde kullanılır.)
             
            int degisken=10;
            degisken++ -> işlem degiskenin sağ tarafında ise önce degiskenin değerini yaz sonra işlemi yap.
            ++degisken -> önce işlemi yapıp sonra değişkenin değerini yazar.
            --degisken -> önce işlem sonra değişken
            degisken-- -> önce değişken sonra işlem
             */
            #endregion
            int i = 10;
            //Console.WriteLine(sayi++); //sayi = sayi + 1;
            //Console.WriteLine(++sayi);
            //Console.WriteLine(sayi++);

            i *= i++ + --i * (i++ - ++i);//-100 sonuç.
            Console.WriteLine($"i değişkeninin değeri =>{i}");

            //Matematiksel işlemler
            int sayi =99;
            int sayi2 = 2;
            //Bu iki sayının  toplama-çıkarma-çarpma-bölme ve mod alma işlemlerini yapınız.
            // + -> aynı zamanda string(metin) birleştirmesi yapar.
            // $ -> metin bir ifadenin başında kullanılınca c# kodu yazmamıza imkan saylar.
            // {}-> index parantezi bazı metotlarda değişkenlerin gösterileceği bölümü belirlemede kullanılır.
            #region Toplama İşlemi
            Console.WriteLine("İşlemin Sonucu: " + (sayi + sayi2));
            Console.WriteLine("İşlemin Sonucu: {0} ",sayi+sayi2);
            Console.WriteLine($"İşlemin Sonucu: {sayi+sayi2}");
            #endregion
            #region Çıkarma İşlemi
            Console.WriteLine($"İşlemin Sonucu: {sayi - sayi2}");
            #endregion
            #region Çarpma İşlemi
            Console.WriteLine($"İşlemin Sonucu: {sayi - sayi2}");
            #endregion
            #region Bölme İşlemi
            double sonuc = Convert.ToDouble(sayi) / Convert.ToDouble(sayi2);
            Console.WriteLine($"İşlemin Sonucu: {sonuc} ");
            #endregion
            #region Mod alma işlemi
            Console.WriteLine($"İşlemin Sonucu: {sayi % sayi2}");
            #endregion


            Console.ReadLine();
        }
    }
}
