using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Tekrar
{
  public abstract  class Hayvan
    {
        public  int  ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public abstract void SesCikar();
        

    }

    public class Kopek : Hayvan
    {
      

        public override void SesCikar()
        {
            //Ses Çıkar
        }
    }

    public class Kedi : IHayvan
    {
       

        public void SesCikar()
        {
            throw new NotImplementedException();
        }
    }
}
