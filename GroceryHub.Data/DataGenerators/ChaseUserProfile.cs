using System;
using GroceryHub.Data.Models;

namespace GroceryHub.Data.DataGenerators
{
    public class ChaseUserProfile
    {
        public static UserProfile Build(Guid userId)
        {
            return new UserProfile
            {
                Id = userId,
                FirstName = "Chase",
                LastName = "Hardin",
                AccessToken = Guid.NewGuid(),
                EntryDate = new DateTime()
            };
        }
    }
}
