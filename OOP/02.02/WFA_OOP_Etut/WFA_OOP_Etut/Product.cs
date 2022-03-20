using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOP_Etut
{
    class Product:BaseEntity
    {
     
       
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public int CategoryID { get; set; }

    
        public override string ToString()
        {
            return string.Format("ID : {0}, ProductName: {1}, Price: {2:C2}, Stock : {3}", ID, Name, Price, Stock);
        }

        public override void VeritabanınaEkle()
        {
            throw new NotImplementedException();
        }

        public override void VeritabanınaEkle(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
