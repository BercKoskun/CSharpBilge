using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_TelefonRehberi
{
    class Sehir
    {
        public string SehirAdi { get; set; }
        public Ulke Ulke { get; set; }
        public string AlanKodu { get; set; }
      


    }
    class Ulke
    {
        public string UlkeAdi { get; set; }
        public string UlkeKodu { get; set; }

    }
}
