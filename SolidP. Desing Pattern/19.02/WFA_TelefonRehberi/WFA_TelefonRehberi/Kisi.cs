using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_TelefonRehberi
{
    class Kisi
    {
        string _ad;
        public string Ad 
        {
            get
            {
                return _ad;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new FormatException("Ad Boş Geçilemez");
                }
                _ad = value;
            }
        }

        public string Soyad { get; set; }

        public Sehir Sehir { get; set; }
       
        public ITelefon Telefon { get; set; }
      

        public override string ToString()
        {
            return string.Format("{0} {1} - {2}", this.Ad, this.Soyad, this.Telefon);
        }

    }
}
