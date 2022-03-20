using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Kalitim
{
   public class Samsung:MobilePhone
    {
        

        public Samsung()
        {
          
        }
        //Base classdan türeyen classlar kendi constructorlarına başvuru yapınca otamatik olarak base classda oluşturulan ctor da çalışır. Fakat base classda birden fazla ctor varsa ne olur? 
        //ahanda aşağıdaki gibi olur :)
        public Samsung(DateTime samsungcikistarihi):base(samsungcikistarihi)
        {
           
        }
        public byte KameraSayisi { get; set; }
        public byte KameraMP { get; set; }
        
    }
}
