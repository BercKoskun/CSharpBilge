using SolidP.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.DIP.Validated.Concrete
{
   public class Balik : IYemek
    {
        public string YemekYap()
        {
            return "Hamsi Tava";
        }
    }
}
