using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_VeriTipleri_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write konsol ekranına yazar ve imleci yanında bırakır. kaç satır sonra olduğunun önemi yok yine konsol ekranına bir değer yazdığınızda imlecin kaldı yerden yazmaya devam eder.
            //WriteLine => ekrana yazar ve imleci alt satıra indirir.
            Console.Write("Merhaba Dünya");

            #region Veri Tipleri

            /*
             * Veri Tipi Nedir?
                Verilerimizi ram üzerinde saklayan alanlardır. 

                RAM nedir?
                Bilgisayarın donanım bileşenlerindendir. Mikroişlemcili sistemlerde kullanılan bir tür veri deposudur. RAM geçici bir
                hafıza birimidir. Bilgisayar çalıştığı süre boyunca üzerinde veri tutabilir. RAM’de ki güç kesildiğinde (Bilgisayar kapatıldığında) RAM, üzerinde bulunan tüm bilgileri kaybeder.
                RAM bellek üzerinde sayısal - metinsel ve mantıksal işlemler yapılmak üzere verileri saklamak ve istediğimizde kullanmamızı sağlayan ise veri tipleridir 
              
             
             Değer tip (Value Type)
             1- Tam Sayı veri tipleri
                    byte,short,int,long
                    sbyte,ushort,uint,ulong
             2- Ondalık Sayı veri tipleri
                    float,double,decimal
             3- Metin Veri Tipleri
                    string,char
             4- Mantık veri tipi
                    bool(boolean)
             6- var veri tipi
                    anonim bir veri tipidir. var ile tanımlanan değişken üzerine atanan değerin tipinde kabul edilir.
             Referans tip (References Type)
             7- object veri tipi
             8- class
             9- Array(dizi)
             */
            #endregion

            #region Değişkenler
            /*
             Değişken Nedir?       
           Değişkenleri en sabit şekilde verilerin depolandğı yerler olarak tanımlayabiliriz.Değişkenlerin içine verilerimizi koyabilirirz veya değişkenlerimizin içindeki verileri C# programındaki işlemlerimiz için kullanabilliriz
         Degisken Kuralları
          1)Kullanmayacagimiz degiskenleri asla tanimlamamaliyiz...
          2)Deger araliklarina gore dogru veri tiplerini secmeye ozen gostermeliyiz... (Degisken Yonetimi = Performans Yonetimi)
          3)Bir degisken adi asla iki kelimeden olusamaz... Eger iki kelime ise mutlaka izin verilen ozel bir karakterle (_) birbirinden ayrilmalidir...
          4)Degisken adlari asla sayiyla baslamaz ancak sayiyla bitebilir...
         */
            #endregion

            int sayi;//değişken tanımlama
            int sayi2 = 10; // değişken tanımlama ve değer atama işlemi
            sayi = 5;//tanımlanan değişkene değer atama
            Console.WriteLine();
            Console.WriteLine(sayi);//Tanımlanmış bir değişkeni ekranda göseriyorum.

            sayi = sayi2;//sayı değişkenine sayi2 değişkeninin değeri atanır.

            string ad = "Rıdvan Aksoy";
            char karakter = 'A';

            #region Escape Sequences
            //   \n => Bir alt satira gecmek icin kullanilir..
            string ikiSatirlikMetin = "Burası birinci satırım\nBurası da ikinci satırım";
            Console.WriteLine(ikiSatirlikMetin);

            //   \t => Metin arasında bir tab'lık bosluk birakmak icin kullanilir..
            string tabliMetin = "Buraya yazdım.\tBu metin de bir tab otede";
            Console.WriteLine(tabliMetin);

            //"Escape Sequences" - "Kaçış Karakterleri" nedir, arastiriniz?

            string ciftTirnakliMesaj = "Beni'm adım \"Bilge Adam\"";
            Console.WriteLine(ciftTirnakliMesaj);
            #endregion

            bool mantıksal = true;
            mantıksal = false;
            mantıksal = 4 < 5;

            Console.WriteLine(mantıksal);

            Console.ReadLine();
        }


    }
}
