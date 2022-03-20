using SolidP.InterfaceSag.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.InterfaceSag.Validated
{
    class Kartal : Kus, IUcabilir, IEtcil
    {
        public int UcusHizi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      

        public void UcusYuksekligi()
        {
            throw new NotImplementedException();
        }
    }
    class Tavuk:Kus,IOtcul
    {

    }
}
