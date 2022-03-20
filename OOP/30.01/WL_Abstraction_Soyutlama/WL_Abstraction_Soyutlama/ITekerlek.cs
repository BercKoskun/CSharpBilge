using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL_Abstraction_Soyutlama
{
    /*
     * INTERFACE
     * 1) Interface'ler yapi olarak class'lara cok benzedigi icin genellikle I harfiyle baslarlar (KURAL DEGİLDİR!)
     * 2) Interface'ler icerisinde degisken tanimlanmaz! Property ve metotlar bulunabilir.
     * 3) Interface'ler icerisinde ogelere access modifier kullanilmaz! C# 8.0 ile bu kural değişti.
     * 4) Interface'ler icerisindeki property'lerin get ve set metotlarinin icerisine birsey yazilmaz!
     * 5) Interface'lere constructor tanimlanmaz!
     * 6) Interface icerisine yazilan metotlarin govde kisimlari bos birakilir. Uygulanan class icerisinde bu degerler doldururulur!
     * 7) Varsayılan Access Modifier ı internal dır. Class lardaki gibi Eb lerinden sadece internal ve public Eb lerini üzerine alabilirler. İçerisindeki öğelerin de Eb leri interface inki kadardır. Bu bağlamda da classlardan ayrılırlar.
     */
    interface ITekerlek
    {
         int TekerlekSayisi { get; set; }
    }
}
