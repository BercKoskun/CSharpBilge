using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NtierApp_Repository.Entity.Concrete;
using NtierApp_Repository.DataContext;
using NtierApp_Repository.BLL.Abstract;
namespace NtierApp_Repository.BLL
{
    public class ProductManager:IRepositoryBase<Product>
    {
        LazBakkalEntities db = new LazBakkalEntities();
        public Product Add(Product item)
        {

            if (item==null)
            {
                return null;
            }

           item= db.Products.Add(item);
            Save();
            return item;
        }

        public Product Update(Product item)
        {
            if (item==null)
            {
                return null;
            }
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            Save();

            return item;
        }

        public bool Delete(Product item)
        {
            if (item==null)
            {
                return false;
            }
            db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            Save();

            return true;
        }
        public Product GetById(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }


        public List<Product> ToListPrice(decimal minPrice,decimal maxPrice)
        {
         return   db.Products.Where(x => x.Price > minPrice && x.Price < maxPrice).ToList();
        }


        public int Save()
        {
          return  db.SaveChanges();
        }

       
    }
}
