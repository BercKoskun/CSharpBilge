using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOP_Hamburgerci.Models
{

    enum Boyut
    {
        Orta,
        Buyuk=2,
        King=3
    }


    class Siparis
    {
       static List<Siparis> _siparisListesi = new List<Siparis>();
        public List<Siparis> Siparisler { get { return _siparisListesi; } }

        public Yemek Hamburger { get; set; }
        public Boyut MenuBoyu { get; set; }
        public string[] Ekstralar { get; set; }
        public short Adet { get; set; }
        public decimal AraToplam { get { return (Hamburger.Fiyat * Adet) +(0.5m*Ekstralar.Length * Adet)+ ((int)MenuBoyu * Adet); } }

        public override string ToString()
        {
            return $"{Hamburger.Ad} -> {Hamburger.Fiyat.ToString("C2")} x {Adet} => {AraToplam.ToString("C2")} ";
        }

        public void SiparisEkle(Siparis yemekSiparisi)
        {
            _siparisListesi.Add(yemekSiparisi);
        }

        public static decimal ToplamSiparis()
        {
          return  _siparisListesi.Sum(x => x.AraToplam);
        }
    }
}
