using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.SRP.Validated
{
    class Futbolcu
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public byte Yas { get; set; }
        public decimal Bonservis { get; set; }
        public decimal Maas { get; set; }
        public string Mevki { get; set; }
        public virtual int SutGucu()
        {
            return 0;
        }
        public virtual int PasGucu()
        {
            return 0;
        }
    }
}
