using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Inheritance_Kalitim
{
    class Kopek:Hayvan
    {
        public bool Kisirmi { get; set; }
        // Virtual olan metotları override ederek görüntüleyebiliriz. Eğer içeriğini değiştirmeyecek isek Override etmemize gerek yoktur.
        public override string SesCikar()
        {
            return "Hav Hav";
        }
        public void YetenekGoster()
        {
           
        }
        

    }
}
