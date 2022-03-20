using NtierApp_Repository.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierApp_Repository.Entity.Concrete
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public int CategoryID { get; set; }

    }
}
