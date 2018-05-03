using GroceryHub.Data.Models;

namespace GroceryHub.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<GroceryHubEntity>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(GroceryHubEntity context)
        {
            context.UserProfiles.AddOrUpdate(x => x.FirstName, new UserProfile
            {
                Id = Guid.NewGuid(),
                FirstName = "Chase",
                LastName = "Hardin",
                AccessToken = Guid.NewGuid(),
                EntryDate = DateTime.Now
            },
            new UserProfile
            {
                Id = Guid.NewGuid(),
                FirstName = "Makenna",
                LastName = "Ridgway",
                AccessToken = Guid.NewGuid(),
                EntryDate = DateTime.Now
            });
        }
    }
}
