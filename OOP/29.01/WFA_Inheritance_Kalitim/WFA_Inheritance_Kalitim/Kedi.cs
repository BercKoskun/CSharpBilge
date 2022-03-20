using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Inheritance_Kalitim
{
   public class Kedi:Hayvan
    {
     
        public bool Kisirmi { get; set; }
        public bool KilVarmi { get; set; }
        // Virtual olan metotları override ederek görüntüleyebiliriz. Eğer içeriğini değiştirmeyecek isek Override etmemize gerek yoktur.
        public override string SesCikar()
        {
            return "Miyav";
        }
        public void DorBacakUstuneDus()
        {

        }

    }
}
