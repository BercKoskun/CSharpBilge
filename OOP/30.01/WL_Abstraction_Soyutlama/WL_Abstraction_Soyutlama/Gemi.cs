using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL_Abstraction_Soyutlama
{
    class Gemi : Tasit,IYakit
    {
        public override decimal Fiyat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void HareketEt()
        {
            throw new NotImplementedException();
        }

        public void YakitAl()
        {
            throw new NotImplementedException();
        }
    }
}
