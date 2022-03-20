using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KapsullemeOrnek
{
    //ad, stok, fiyat, sonkullanma tarihi field ve property lerini hazırlayınız

    class Urun//:Object
    {
        string _ad;
        decimal _fiyat;
        short _stok;
        DateTime _sonKullanmaTarihi;

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
                    throw new Exception("Ad Boş Bırakılamaz");
                }

                _ad = value;
            }
        }
        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                if (value<=0)
                {
                    throw new Exception("Fiyat 0 ve 0 dan kuçük olamaz");
                }
                _fiyat = value;
            }
        }

        public short Stok
        {
            get
            {
                return _stok;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception("Stok 0 dan küçük girilemez");
                }

                _stok = value;
            }

        }

        public DateTime SonKullanmaTarihi
        {
            get
            {
                return _sonKullanmaTarihi;
            }
            set
            {
                if (value<DateTime.Now.AddDays(15))
                {
                    throw new Exception("Eklenen ürünün son kullanma tarihi, eklenme tarihinden 15 gün sonrası olmalıdır.");
                }
                _sonKullanmaTarihi = value;
            }
        }

        //override => base(kalıtım verilen) classlardaki virtual tanımlanan oğleri kendi classınızda çalışmasını istediğiniz hale getirmek için kullanılır.

        //base class 'da (miras alınan sınıfta) "virtual" tanımlanan metotlar, driven class 'larda (miras alan sınıflarda) isteğe bağlı olarak "override" (ezmek yani farklı davrandırmak) edilebilir.
        //Bu tekniğe OOP 'da PolyMorphism (Çok Biçimlilik) denir.
        //Bu class object sınıfından miras aldığı için "base" anahtar kelimesi object sınıfının NESNESİNİ temsil eder. ToString metotu object sınıfında tanımlanmıştır. .Net 'de tüm tipler object sınıfından türediği için, anlamlı bir etiket göstermeleri gereksiniminden dolayı, tüm nesnelerin ToString metotu vardır. 
        //ToString metotu object sınıfında "virtual" tanımlandığında dolayı bu sınıf içerisinde "override" edilebilir.
        public override string ToString()
        {
            //return this.Ad;
            return $"Ad: {this.Ad}, Fiyat: {this.Fiyat}, Stok: {this.Stok}, Son Kullanma Tarihi: {this.SonKullanmaTarihi}";
        }

    }
}
