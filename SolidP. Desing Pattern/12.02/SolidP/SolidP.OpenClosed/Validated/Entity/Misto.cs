using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.OpenClosed.Validated.Entity
{
    using BaseClass;
    class Misto : KahveFiyatlama
    {
        public override decimal KahveFiyatiHesapla(int miktar)
        {
            return miktar * 5;
        }
    }
}
