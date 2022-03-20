using NtierApp_Repository.BLL.Abstract;
using NtierApp_Repository.DataContext;
using NtierApp_Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierApp_Repository.BLL
{
    public class OrderManager : IRepositoryBase<Order>
    {
        LazBakkalEntities db = new LazBakkalEntities();
        public Order Add(Order item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order item)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
