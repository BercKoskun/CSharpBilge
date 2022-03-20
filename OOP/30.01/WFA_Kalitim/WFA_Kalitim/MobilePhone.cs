using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Kalitim
{
    public class MobilePhone
    {

        public MobilePhone()
        {
            _uretimtarihi = DateTime.Now;
        }

        public MobilePhone(DateTime cikistarihi)
        {
            _uretimtarihi = DateTime.Now;
            _cikistarihi = cikistarihi;
        }

        private DateTime _cikistarihi;
        public DateTime CikisTarihi { get{ return _cikistarihi; } }

        private DateTime _uretimtarihi;
        public DateTime UretimTarihi { get { return _uretimtarihi; } }

        string _model;
        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Model bilgisini boş bıramazsınız...");
                }
                _model = value;
            }

        }

        public string Aciklama { get; set; }
        public byte Agirlik { get; set; }
        public string Pilsuresi { get; set; }
        public byte Uzunluk { get; set; }
        public byte Ram { get; set; }
        public byte Inc { get; set; }
        public short Hafiza { get; set; }
        public bool ikincielmi { get; set; }
        public bool Calisirmi { get; set; }

        public Color Renk { get; set; }
        public string Madein { get; set; }

    }
}
