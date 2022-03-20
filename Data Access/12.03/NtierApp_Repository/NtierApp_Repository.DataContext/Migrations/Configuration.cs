namespace NtierApp_Repository.DataContext.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NtierApp_Repository.DataContext.LazBakkalEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NtierApp_Repository.DataContext.LazBakkalEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Categories.Add(new Entity.Concrete.Category()
            {
                Name = "Gıda",
                Description = "sebze meyve",
                CreatedBy = "Ridvan",
                ModifiedDate = DateTime.Now

            });
           
        }
    }
}
