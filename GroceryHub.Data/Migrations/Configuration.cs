using GroceryHub.Data.DataGenerators;

namespace GroceryHub.Data.Migrations
{
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
            context.UserProfiles.AddOrUpdate(x => x.Id,
                UserProfileData.ChaseProfile(),
                UserProfileData.MakennaProfile());
        }
    }
}
