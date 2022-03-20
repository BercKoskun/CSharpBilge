using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_ArrayClass
{
    class Program
    {

        //int[] sayilar = new int[100]; dizi tanımlama yöntemi
        static void Main(string[] args)
        {
            //Array Sınıfı
            // dizileri yönetmemiz için oluşturulan sınıftır. Nasıl sayı dönüştürmek için Convert sınıfı ya da rastgele sayı üretmek için Random sınıfını kullandıysak bu sınıfıda dizileri düzenlemek ya da yönetmek için kullanırız.
            //bu işlemler dizinin tüm elemanlarını baz alarak gerçekleşir. 

            string[] sehirler = { "Hakkari", "Edirne", "İstanbul", "Kars", "Muğla", "Hatay", "Sinop", "Ankara", "İstanbul", "İzmir" };

            #region Dizye eleman atama
            //diziye eleman atama işlemi => bir diziye eleman vermek için index(sıra numarası, 0 dan başlar) numarası ile atama yapılabilir.
            //sehirler[8] = "Yozgat"; 
            #endregion

            #region Diziden Eleman Okuma
            //bir dizi elemanını okuma
            // Console.WriteLine(sehirler[8]);
            //yada
            //string istenensehir = sehirler[8]; 
            #endregion

            #region Array.Clear
            //Dizinin Tüm Elemanlarını Temizleme(dizinin eleman sayısı değişmez.)
            //Array.Clear(sehirler, 0, sehirler.Length); 
            #endregion

            #region Array.Copy
            //Bir dizinin başka bir diziye kopyalanması.
            //int elemansayisi = sehirler.Length;
            //string[] sehirler2 = new string[elemansayisi];
            //Array.Copy(sehirler, sehirler2, elemansayisi);
            //Array.Clear(sehirler2, 0, sehirler2.Length); 
            #endregion

            #region Array.IndexOf
            // Bir verinin dizi içerisinde kaçıncı sırada olduğunu belirten metot.
            //veri dizi elemanları ile aynı formatta yazılmalı. ayrıca bu metot birden fazla aynı eleman var ise ilk bulduğu elemanın sıra numarası yani indexini döndürür.
            //eğer elemanı bulamazsa -1 değeri döndürür. 0 ilk sıra olduğu için olaki elman ilk sıradaysa 0 döndürür. yanlış anlaşılmasın.
            // int sırano=Array.IndexOf(sehirler, "İstanbul"); 
            #endregion

            #region Array.LastIndexOF
            //Dizinin elemanlarında sondan başlayarak istenilen değer var mı? yok mu? bilgisini döndürür. IndexOfun ters hali diyebiliriz.
            // int sondansirano = Array.LastIndexOf(sehirler, "İstanbul");
            #endregion

            #region Array.Reverse
            //Dizi elemanlarının sıralarını tesr çevirir. ilk elemandan başlayarak son elemana kadar yer değişkiliği yapar.
            // Array.Reverse(sehirler);

            #endregion

            #region Array.Sort
            //Dizinin elemanlarını K>B ya da A-Z sıralama yapar.
            //  Array.Sort(sehirler);
            #endregion

            #region Dizi Sorusu ve Çözümü

            // sehirler dizinin elemanlarını Z-A şeklinde sıralayınız.
            //Array.Sort(sehirler);
            //Array.Reverse(sehirler);
            //Console.WriteLine(sehirler[0]);
            //Console.WriteLine(sehirler[1]);
            //Console.WriteLine(sehirler[2]);
            //Console.WriteLine(sehirler[3]);
            //Console.WriteLine(sehirler[4]);
            //Console.WriteLine(sehirler[5]);
            //Console.WriteLine(sehirler[6]);
            //Console.WriteLine(sehirler[7]);
            //Console.WriteLine(sehirler[8]);
            //Console.WriteLine(sehirler[9]); 
            #endregion

            // sehirler[10] = "Rize"; // bu işlem dizinin eleman sayısı 10 olduğu için hata verir. dizilerin eleman sayılarını kafamıza göre yükseltemeyiz. dizi eleman sayısında değişiklik yapmak istersek Array.Resize metodunu kullanırız.
            #region Array.Resize
            //Eleman sayısını değiştirmek

            //Eleman sayısını + yönde değiştirmek
            //int mevcutelemansayisi = sehirler.Length;
            //Array.Resize(ref sehirler, mevcutelemansayisi + 5);


            //Eleman sayısını - yönde değiştirmek
            //int mevcutelemansayisi = sehirler.Length;
            //Array.Resize(ref sehirler, mevcutelemansayisi - 5);

            //herhangi bir eleman sayısı atamak
            //Array.Resize(ref sehirler, 115);

            //elaman sayısını bir arttır ve dizinin son elemanına Rize ilini ekle
            Array.Resize(ref sehirler, sehirler.Length + 1);
            int son_elemanın_bulundugu_sira = sehirler.Length - 1;
            sehirler[son_elemanın_bulundugu_sira] = "Rize";
        //https://referencesource.microsoft.com/#mscorlib/system/array.cs,71074deaf111c4e3
            #endregion

        }
    }
}
