using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.Liskov.Bad
{
   public class Sekil
    {
        public int Yukseklik { get; set; }
        public int Genislik { get; set; }

        public int AlanHesapla(int genislik,int yukseklik)
        {
          
            return genislik * yukseklik;
        }
    }
}
