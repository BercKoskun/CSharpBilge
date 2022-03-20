using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using NTierApp.DAL.Entity;

namespace NTierApp.Map
{
   public class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Products");

            Property(p => p.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(p => p.Price).IsOptional().HasColumnType("money");
            Property(p => p.Stock).IsOptional().HasColumnType("smallint");

            //Tablolar Arası İlişlilendirme (bire-Çok)
            HasRequired<Category>(c => c.Category)
                  .WithMany(p => p.Products)
                  .HasForeignKey(x => x.CategoryID);
        }
    }
}
