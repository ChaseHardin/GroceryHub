using System.Data.Entity;
using GroceryHub.Data.Models;

namespace GroceryHub.Data
{
    public class GroceryHubEntity : DbContext
    {
        public GroceryHubEntity() : base("GroceryHubConnectionString") { }

        public DbSet<UserProfile> Movies { get; set; }
    }
}
