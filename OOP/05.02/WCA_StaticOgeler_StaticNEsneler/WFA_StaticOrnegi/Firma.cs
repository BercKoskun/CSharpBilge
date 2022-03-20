using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_StaticOrnegi
{
    class Firma
    {
        private static Firma[] _firmalar=new Firma[0];

        public void FirmaEkle(Firma Musteri)
        {
            Array.Resize(ref _firmalar, _firmalar.Length + 1);
            _firmalar[_firmalar.Length - 1] = Musteri;

        }

        #region metoda parametre vermeden içinde bulunduğu formu temsil eden ekleme yöntemi
        //public void FirmaEkle()
        //{
        //    Array.Resize(ref _firmalar, _firmalar.Length + 1);
        //    _firmalar[_firmalar.Length - 1] = this;

        //} 
        #endregion

        public static Firma[] Firmalar { get { return _firmalar; } }

        public string FirmaAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }

        public override string ToString()
        {
            return this.FirmaAdi;
        }






    }
}
