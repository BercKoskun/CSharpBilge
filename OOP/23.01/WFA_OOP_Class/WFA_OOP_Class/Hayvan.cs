using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOP_Class
{
  //Nesnenin özelliklerini(Property) ve davranışlarını(Metot) tanımlayan şablonlardır.
  //Bir Class sadece Internal ve Public erişim belirteçlerini sahiplenebilir.
  //Private -> ÖZel sadece kendi classında görnür. Bu yüzden classlar private olamaz.

    //Internal -> kendi projesinde ki tüm classlar tarafından görünebilir.
    //Public -> tüm projeler tarafında ki classlardan görünebilir.
 /*internal*/ public   class Hayvan
    {
        //Propety=> nesne için tanımlanan özellikler olarak adlandırılır. değer ataması yada okuması yapılır. bazı durumlarda sadece okuma ya da sadece yazma özellikleri verilebilir.
        #region Diğer Dillerde GEt ve Set işlemi
        //get: get metodu olarak adlandırılır.nedeni ise c# dan önceki gelişmiş oop tabandı dillerde (c++ ve Java) nesne içerisinde property diye bir kavram yoktur.
        /*
         class Hayvan
        {
            string _cinsi //field
          public string getterCinsi()//fieldaki değeri okuması için tanımlanır.
               {
                    return _cinsi;
                }
          public void setterCinsi(string value) //field'a değer ataması yapmak için
           {
                 _cinsi=value;
           }
        
        }
         
         */ 
        #endregion
        public string Cinsi { get; set; }//auto implemented property
        public string Renk { get; set; }
        public string Ad { get; set; }
        public byte Agirlik { get; set; }
        internal byte Yas { get; set; }


        //Metotlar classların(Nesnelerin) davranışlarını belirlediğimiz yapılardır.
        public void SesCikar()
        {

        }
    }

}
