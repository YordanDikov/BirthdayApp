namespace BirthdayApp.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BirthdayApp.Models;

    public sealed class Configuration : DbMigrationsConfiguration<BirthdayApp.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BirthdayApp.Data.ApplicationDbContext context)
        {
            base.Seed(context);
            if (context.Categories.Count() == 0)
            {
                context.Categories.Add(new Category()
                {
                    Name = "Friends"
                });
                context.Categories.Add(new Category()
                {
                    Name = "Family"
                });
                context.Categories.Add(new Category()
                {
                    Name = "Pets"
                });

                context.SaveChanges();
            }
        }
    }
}
