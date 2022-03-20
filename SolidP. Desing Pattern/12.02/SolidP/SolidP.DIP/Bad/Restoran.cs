using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.DIP.Bad
{
  public  class Restoran
    {

        Balik b = new Balik();
        Tavuk t = new Tavuk();

        public void YemekYap()
        {
            //Balik sınıfında BalikYemegiYap metedonu kaldırdığımızda Restoran sınıfında da bu konu ile alakalı değişikleri düzenlememiz lazım. Bu durumda bizi yani Restoran classını Balik classına bağımlı hale getirir. Aynı durum Balik claası gibi tanımlanan diğer nesnelerde de geçerlidir.
            b.BalikYemegiYap();
            t.TavukYemegiYap();
        }

    }
}
