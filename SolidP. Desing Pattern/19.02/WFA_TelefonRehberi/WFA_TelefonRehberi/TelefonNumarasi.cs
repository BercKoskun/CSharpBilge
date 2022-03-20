using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_TelefonRehberi
{
    interface ITelefon
    {

    }

   abstract class TelefonNumarasi:ITelefon
    {
        public string Numara { get; set; }
        public string UlkeKodu { get; set; }

    }

    class AlanKoduOlanNumaralar:TelefonNumarasi
    {
        public string AlanKodu { get; set; }
    }

    class AlanKoduOlmayanNumaralar:TelefonNumarasi
    {

    }
}
