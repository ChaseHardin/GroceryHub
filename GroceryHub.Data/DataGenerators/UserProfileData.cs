using System;
using GroceryHub.Data.Models;

namespace GroceryHub.Data.DataGenerators
{
    public static class UserProfileData
    {
        public static Guid ChaseId = Guid.Parse("546ba5f7-f687-45ab-b911-8cbe777004a8");
        public static Guid MakennaId = Guid.Parse("5186173b-be3d-4479-8321-55fa6d3fa4f3");

        public static UserProfile ChaseProfile()
        {
            return new UserProfile
            {
                Id = ChaseId,
                FirstName = "Chase",
                LastName = "Hardin",
                AccessToken = Guid.Parse("5fcc1842-2056-41c2-9df3-4c3e1b18cdd1"),
                EntryDate = DateTime.Now
            };
        }

        public static UserProfile MakennaProfile()
        {
            return new UserProfile
            {
                Id = MakennaId,
                FirstName = "Makenna",
                LastName = "Ridgway",
                AccessToken = Guid.Parse("d430704f-dcd3-4639-860f-00f258d192ec"),
                EntryDate = DateTime.Now
            };
        }
    }
}
