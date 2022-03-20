using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOP_Etut
{
    class Category:BaseEntity
    {
      
        public string Description { get; set; }

        public override string NesneyiGoruntule()
        {
            return string.Format("ID: {0} Name: {1} Description: {2}",ID,Name,Description);
        }

        public override void VeritabanınaEkle()
        {
           
        }

        public override void VeritabanınaEkle(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
