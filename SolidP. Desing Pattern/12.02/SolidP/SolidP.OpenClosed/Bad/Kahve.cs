using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidP.OpenClosed.Bad
{

    enum KahveCesitleri {
        Latte,
        Espresso,
        Mocha,
        Misto,
        Americano

    }

    class Kahve
    {


        public decimal KahveFiyatiHesapla(int miktar,KahveCesitleri kahve)
        {
            //Bu metot içerisinde yazdığınız kod çalışıyor ama siz bunu yeni özellikler için değiştiriyorsanız hata yapıyorsunuz demektir.
                switch (kahve)
            {
                case KahveCesitleri.Latte:
                    return miktar * 7;
                case KahveCesitleri.Espresso:
                    return miktar * 9;
                case KahveCesitleri.Mocha:
                    return miktar * 15;
                case KahveCesitleri.Misto:
                    return miktar * 5;
                case KahveCesitleri.Americano:
                    return miktar * 12;

            }
            return 0;
        }
    }
}
