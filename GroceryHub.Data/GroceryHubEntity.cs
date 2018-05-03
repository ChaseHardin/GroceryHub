using System.Data.Entity;
using GroceryHub.Data.Models;

namespace GroceryHub.Data
{
    public class GroceryHubEntity : DbContext
    {
        public GroceryHubEntity() : base("GroceryHubConnectionString") { }

        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<GroceryHubEntity>(null);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserProfileConfiguration());
        }
    }
}
