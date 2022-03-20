using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL_Abstraction_Soyutlama
{
    class Otomobil : Tasit,ITekerlek,IYakit
    {
        decimal _fiyat;
        public override decimal Fiyat 
        { 
            get => _fiyat;
            set => _fiyat = value; }
        public int TekerlekSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void HareketEt()
        {
           //Otomobil Ucar Gider
        }

        public void YakitAl()
        {
            throw new NotImplementedException();
        }
    }
}
