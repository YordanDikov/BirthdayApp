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
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BirthdayApp.Data.ApplicationDbContext context)
        {
        }
    }
}
