using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NTierApp.DAL.Entity;
using NTierApp.Map;

namespace NTierApp.DAL.Context
{
   public class OsmanPazarlamaEntities:DbContext
    {
        public OsmanPazarlamaEntities() : base("server=.;database=OPDB;uid=sa;pwd=12345678;MultipleActiveResultSets=true")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());

            base.OnModelCreating(modelBuilder);
        }


    }
}
