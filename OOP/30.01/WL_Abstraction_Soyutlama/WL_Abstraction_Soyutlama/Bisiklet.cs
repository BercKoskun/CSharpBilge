using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL_Abstraction_Soyutlama
{
    class Bisiklet : Tasit,ITekerlek
    {
        public override decimal Fiyat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TekerlekSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void HareketEt()
        {
            throw new NotImplementedException();
        }
        public override string SesCikar()
        {
            return "fizzzzzz";
        }

       
    }
}
