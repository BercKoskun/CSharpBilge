using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOP_Collections.Models
{
    class Personel
    {
      
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public byte Yas { get; set; }

        public override string ToString()
        {
            return $"{this.Ad} {this.SoyAd}";
        }

    }
}
