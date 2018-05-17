using System;
using System.Net;
using GroceryHub.API.Tests.Context;
using GroceryHub.Data;
using GroceryHub.Data.DataGenerators;
using GroceryHub.Data.Models;
using TechTalk.SpecFlow;

namespace GroceryHub.API.Tests.Steps
{
    [Binding]
    public sealed class UserProfileSteps
    {
        [Given(@"a user profile exists")]
        public void GivenAUserProfileExists()
        {
            var userProfile = ChaseUserProfile.Build(Guid.NewGuid());

            SaveUserProfile(userProfile);

            var context = GroceryHubFeatureContext.Get();
            context.UserProfile = userProfile;
            context.AddSubstitute("id", userProfile.Id.ToString());
        }

        private static void SaveUserProfile(UserProfile userProfile)
        {
            using (var db = Application.GetDatabaseInstance())
            {
                db.UserProfiles.Add(userProfile);
                db.SaveChanges();
            }
        }
    }
}
