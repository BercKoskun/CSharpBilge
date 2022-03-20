using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA__Enum
{
    enum KahveBoyutu
    {
        Buyuk,
        Orta,
        Kucuk
    }


    class Kahve
    {
        public string Adi { get; set; }
        public decimal Fiyatı { get; set; }
        public short Adet { get; set; }
        public KahveBoyutu Boyut { get; set; }

    }
}
