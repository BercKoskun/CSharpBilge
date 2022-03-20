using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL_Abstraction_Soyutlama
{
    //Abstract olara işaretlenen classlar soyut nesne olur. Ramde öğe oluşturmaz. sadece kalıtım vermek için kullanılırlar.
    public abstract class Tasit
    {
        public Tasit()
        {
           
        }

        public Color Renk { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public DateTime UretimTarihi { get; set; }
        public abstract decimal Fiyat { get; set; }
        public short YolcuSayisi { get; set; }
        public int Agirlik { get; set; }


        public virtual string SesCikar()
        {
            return "Viiiiyuuuvv";
        }
        //Bir öğeyi abstract olarak işaretlemek için Class da abstract işaretlenmeli
        public abstract void HareketEt();


       

    }
}
