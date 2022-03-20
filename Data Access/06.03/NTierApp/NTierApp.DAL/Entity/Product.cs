using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL.Entity
{
   public class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public short Stock { get; set; }

        public virtual Category Category { get; set; }

    }
}
