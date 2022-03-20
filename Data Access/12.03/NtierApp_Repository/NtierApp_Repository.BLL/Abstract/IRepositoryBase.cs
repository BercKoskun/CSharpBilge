using NtierApp_Repository.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierApp_Repository.BLL.Abstract
{
   public interface IRepositoryBase<T> where T:BaseEntity, new()
    {
        T Add(T item);
        T Update(T item);
        bool Delete(T item);
        T GetById(int id);
        List<T> GetAll();
        

    }

    //GenericRepository kullanmazsak aşağıdaki gibi olur ve karışık olur.boxing-unboxing işlemleri ile dolu bir yapımız olur.
    //public interface IRepositoryBase
    //{
    //    object Add(object item);
    //    object Update(object item);
    //    int Delete(object item);
    //    List<object> GetAll();
    //    object GetById(int id);

    //}
}
