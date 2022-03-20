using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOP_Etut
{
   abstract class BaseEntity
    {
        public int ID { get; set; }

        string _name;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Ad Boş Geçilemez");
                }
                _name = value;
            }
        }


        public virtual string NesneyiGoruntule()
        {
            return string.Format("ID : {0}, ProductName: {1}", ID, Name);
        }

        public abstract void VeritabanınaEkle(); 
        public abstract void VeritabanınaEkle(BaseEntity entity);
    }
}
