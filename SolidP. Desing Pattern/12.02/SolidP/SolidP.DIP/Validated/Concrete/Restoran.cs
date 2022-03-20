using SolidP.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.DIP.Validated.Concrete
{
   public class Restoran
    {
       List<IYemek> _yemekler;
        public Restoran(List<IYemek> siparisEdilenYemekler)
        {
            _yemekler = siparisEdilenYemekler;
        }

        public string RestoranSipraisiVer()
        {
            string yemekadları = "";
            foreach (IYemek yemek in _yemekler)
            {
               yemekadları += yemek.YemekYap().ToString();
            }
            return yemekadları;
        }
    }
}
