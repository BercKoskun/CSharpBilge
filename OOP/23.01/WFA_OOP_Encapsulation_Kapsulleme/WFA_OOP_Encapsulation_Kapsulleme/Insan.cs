using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOP_Encapsulation_Kapsulleme
{
    class Insan
    {


        #region Kapsulleme
        private string _tcKimlikNo;//Class öğesi

        public string TcKimlikNo
        {
            get
            {
                return _tcKimlikNo;
            }
            set
            {
                if (value.Length != 11)
                {
                    //throw => hata var demek için kullanırız.(hata fırlatmak için)
                    throw new Exception("TcKimlikNo 11 karakterden oluşmalıdır.");
                }

                _tcKimlikNo = value;//Atanan değer
            }
        }
        #endregion


        //Best P.
        //class öğesi olarak field kabul edilir. bir field class dışından değer alacaksa yada değer atanması yapılacaksa aşağıdaki yöntem en iyi kod yazma yöntemidir. C# özelinde auto implement property özelliği aslında aşağıdaki kod düzenin kendisi oluşturur.
       private string _ad;
        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {

                _ad = value;
            }
        }
        public string Soyad { get; set; }

    }
}
