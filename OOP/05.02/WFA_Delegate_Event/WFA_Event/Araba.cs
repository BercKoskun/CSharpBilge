using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Event
{
    public delegate void HizAsimiEventi();
    class Araba
    {
        public Araba(int hiz,string model)
        {
            Hiz = hiz;
            Model = model;
        }


        //EB  tanımlama izleyici    event adi
        public event HizAsimiEventi HizAsimi;
        private int _hiz;
        public int Hiz {
            get
            {
                return _hiz;
            }
            set
            {
                if (value>100)
                {
                    HizAsimi();//Event tetiklendi
                }
                _hiz = value;
            }
        
        }
        public string Model { get; set; }

    }
}
