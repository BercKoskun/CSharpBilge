using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.Liskov.Validated
{
   public  class Dikdortgen : Sekil
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }

        public override int AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
}
