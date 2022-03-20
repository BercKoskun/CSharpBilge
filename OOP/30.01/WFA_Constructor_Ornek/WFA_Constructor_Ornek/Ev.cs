using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Constructor_Ornek
{
    class Ev
    {
        public Ev()
        {
            _ilantarihi = DateTime.Now;
        }
        public Ev(byte odasayisi,byte bulundugukat,bool karanlikodavarmi,string adres,string aciklama,short metrekare)
        {
            this.OdaSayisi = odasayisi;
            this.BulunduguKat = bulundugukat;
            this.KaranlikOdaVarmi = karanlikodavarmi;
            this.Adres = adres;
            this.Aciklama = aciklama;
            this.Metrekare = metrekare;

            _ilantarihi = DateTime.Now;
        }
        DateTime _ilantarihi;
        public DateTime IlanTarihi
        {
            get { return _ilantarihi; }

        }
        public byte OdaSayisi { get; set; }
        public byte BulunduguKat { get; set; }
        public bool KaranlikOdaVarmi { get; set; }
        public string Konum { get; set; }
        public string Adres { get; set; }
        public short Metrekare { get; set; }
        public string Aciklama { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }

       

    }
}
