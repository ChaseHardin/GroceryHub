using GroceryHub.Data.Models;

namespace GroceryHub.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GroceryHub.Data.GroceryHubEntity>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GroceryHub.Data.GroceryHubEntity context)
        {
            //  This method will be called after migrating to the latest version.

            context.UserProfiles.AddOrUpdate(
                up => up.Id, new UserProfile
                {
                    Id = new Guid(),
                    FirstName = "Chase",
                    LastName = "Hardin",
                    AccessToken = new Guid(),
                    EntryDate = DateTime.Now
                });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
