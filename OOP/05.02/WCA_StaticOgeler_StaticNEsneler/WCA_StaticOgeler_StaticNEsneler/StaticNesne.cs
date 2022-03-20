using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_StaticOgeler_StaticNEsneler
{
    /*
    * STATIC CLASS
    * Eger nesneye bagimli islemler gerceklestirmiyorsaniz - yani amac sadece belirli bir duruma hizmet eden birden fazla ogeyi bir araya toplamak ise - ilgili sınıfı static olarak isaretleyebilir ve icerisindeki tum ogelere instance'dan bagimsiz olarak ulasabilirsiniz...
    * 
    * Static sınıflar icerisinde yalnizca static ogeler barinabilir (field, property, method...)
    * 
    * Static bir class baska bir classtan kalitim alamaz! Ancak .NET Framework mantigi geregi, tum sınıflar System.Object sınıfından kalitim alirlar. Static sınıflar da bu kalitim islemine dahildir...
    * 
    * Static sınıflara en guzel iki ornek Math ve File sınıflaridir. Ayni amaca (Math => Matematiksel islemlerin bir arada tutulmasi; File => Dosya bazli islemler gerceklestiren birden fazla islemin bir arada tutulmasi) hizmet eden ogeleri icerisinde barindiran ve hizlica ulasmamizi saglayan siniflardir.
    * 
    * Ancak her sinif static olarak isaretlenmemelidir. Cunku tanimlamis oldugunuz her static sinif size ufak da olsa performans kaybi olarak donecektir... 
    */
  static class StaticNesne
    {
        public static decimal YerCekimiKuvveti { get { return 9.81M; } }

        public const int KaldırmaKuvveti = 12;

        public static void Hesapla()
        {

        }


    }
}
