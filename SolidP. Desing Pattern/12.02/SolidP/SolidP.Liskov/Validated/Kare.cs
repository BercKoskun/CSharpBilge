using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.Liskov.Validated
{
 public  class Kare : Sekil
    {
        public int KenarUzunlugu { get; set; }

        public override int AlanHesapla()
        {
            return KenarUzunlugu * KenarUzunlugu;
        }
       
    }
}
