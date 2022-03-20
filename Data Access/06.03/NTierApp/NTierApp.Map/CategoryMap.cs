using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using NTierApp.DAL.Entity;

namespace NTierApp.Map
{
   public class CategoryMap:EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Categories");

            Property(c => c.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            
            Property(c => c.Description).IsRequired().HasColumnType("varchar").HasMaxLength(250);

         
        }
    }
}
