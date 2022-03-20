using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierApp_Repository.Entity.Abstract
{
  public  enum Status
    {
       Active= 1,
       Deleted= 2,
       Created= 3,
       Modified= 4
    }

  public abstract  class BaseEntity
    {
        public BaseEntity()
        {
            Status = Status.Active;
            CreatedDate = DateTime.Now;
        }
        public int ID { get; set; }
        public Status Status  { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
