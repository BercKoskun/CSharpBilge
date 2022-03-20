using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NtierApp_Repository.Entity.Concrete;
namespace NtierApp_Repository.DataContext
{
   public class LazBakkalEntities:DbContext
    {

        public LazBakkalEntities():base("server=.;database=LZBakkalDb;uid=sa;pwd=12345678;multipleactiveresultsets=true")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("money");
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar");

            modelBuilder.Entity<Category>().Property(x => x.Name).HasMaxLength(50).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnType("varchar").HasMaxLength(350).IsOptional();

            base.OnModelCreating(modelBuilder);
        }
    }
}
