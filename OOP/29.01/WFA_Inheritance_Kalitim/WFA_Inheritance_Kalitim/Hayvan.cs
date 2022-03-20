using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Inheritance_Kalitim
{

    //Bir Class sadece bir classdan kalıtım alabilir. Bir class ise birden fazla class'a kalıtım verebilir.
    //Her classın base'i birtane olur.
  public  class Hayvan
    {

        public Hayvan()
        {

        }

        public Hayvan(string ad,string tur)
        {
            this.Adi = ad;
            this.Tur = tur;
        }



       //protected => bir nesnenin özellik yada metotlarının sadece nesnenin kalıtım verdiği classlar tarafından erişilebilir olmasını sağlar. yani bu örnek için Tur özelliğini protected yapınca sadece Hayvan classından türeyen classlar bu özelliği görebilir. İnstance alındığında bu özellik görünmez. 
        protected string Tur { get; set; }

        //protected internal -> Protected olarak işaretlenen öğeler sadece mevcut class içerisinden kontrol edilirler. eğer programın herhangi bir bölümünde bu öğeye erişmek gerekirse o zaman hem protected hemde internal özelliği atanmalıdır.
      protected internal string Adi { get; set; }
        public string Cinsiyet { get; set; }
        public Color Renk { get; set; }
        public byte Yas { get; set; }
        public byte Uzunluk { get; set; }
        public byte Agirlik { get; set; }
        public bool Hastami { get; set; }
        public string Anavatani { get; set; }
        //Virtual methods (sanal metotlar), base class (temel sınıf) içinde bildirilmiş ve derived class (türemiş sınıf) içinde de tekrar bildirilebilen metotlardır. Böylelikle sanal metotlar kullanılarak nesne yönelimli programlama da çok sık başvurulan çok biçimliliği yani poliformizm (polimorphizm) uygulanmış olur. Yani temel sınıfta bir sanal metot bildirildiğinde bu temel sınıftan türeyen sınıflardaki metotlar override edilerek, temel sınıftaki sanal metotu devre dışı bırakabilirler.
        public virtual string SesCikar()
        {
            return "blabla";
        }

        public void TuvaletiYap()
        {

        }
        public void YemekYe()
        {

        }
    }
}
