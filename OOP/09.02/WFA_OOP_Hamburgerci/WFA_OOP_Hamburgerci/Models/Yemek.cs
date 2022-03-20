using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOP_Hamburgerci.Models
{
    class Yemek
    {

        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public string Tarifi { get; set; }


        public override string ToString()
        {
            return this.Ad;
        }
    }
}
