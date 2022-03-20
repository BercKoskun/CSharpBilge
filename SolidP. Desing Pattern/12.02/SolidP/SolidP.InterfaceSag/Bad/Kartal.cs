using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.InterfaceSag.Bad
{
    class Kartal:Kus,IKus
    {
        public Kartal()
        {
          
            this.Yuruyabilir = true;
        }

        public bool Ucabilir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BeslenmeAliskanligi()
        {
            throw new NotImplementedException();
        }
    }

    class Tavuk :Kus,IKus
    {
        public Tavuk()
        {
            this.Yuruyabilir = true;
           
        }

        public bool Ucabilir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BeslenmeAliskanligi()
        {
            throw new NotImplementedException();
        }
    }
}
