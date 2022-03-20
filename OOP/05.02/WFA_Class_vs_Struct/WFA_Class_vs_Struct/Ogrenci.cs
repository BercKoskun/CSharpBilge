using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Class_vs_Struct
{
    /*
    * Struct yapı gereği değer tipli olduğundan Ram üzerinde Stack alanda tutulmaktadır. Her ne kadar Class'a yapı olarak benzesede, özellikleriyle ayrılmaktadır.

       1) struct yapılarda bos yapıcı (Constructur) tanımlanamaz.
       2) Eğer yapıcı metot tanımlanacak ise, mutlaka parametre almak zorundadır.
       3) Parametreli tanımlanan yapıcı metot içerisinde, değerlere başlangıç değerleri atanmak zorundadır.
       4) Struct yapılarda boş yapıcı metot tanımlanamadığından dolayı new anahtar kelimesi kullanılamaz diye bir kavram yoktur. Class yapılarından yapı derlendiğinde eğer siz default boş bir yapıcı metot oluşturmadıysanız, yapı derlendiğinde otomatik olarak " void .ctor() " metodu çalışarak oluşturacaktır.


       Eğer yapı olarak inceler isek, IL(Intermediate Language) koduna göre class için " newobj " olarak yapılandırılır iken, struct için " initobj " yapısı çalışmaktadır.

       Bir başka deyişle initobj çağrısının uygulandığı Struct içerisindeki Primitive tipler için, varsayılan ilk değer atamaları gerçekleştirilmektedir. Buna göre sayısal değerler için 0 veya 0.0, bool için false ve referans türleri için de null değerlerin atanması söz konusudur. Açıkça ifade etmek gerekirse Struct' lar için varsayılan bir yapıcı metod söz konusu olmasa dahi, IL tarafında bu fonksiyonelliği üstelenen bir çağrı yapılmaktadı
    */
    public struct Ogrenci
    {
       
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
