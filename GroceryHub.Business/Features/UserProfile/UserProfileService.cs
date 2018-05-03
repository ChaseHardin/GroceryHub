using System.Collections.Generic;
using System.Linq;
using GroceryHub.Data;

namespace GroceryHub.Business.Features.UserProfile
{
    public class UserProfileService
    {
        public IEnumerable<UserProfileViewModel> GetProfile()
        {
            using (var db = Application.GetDatabaseInstance())
            {
                return db.UserProfiles.Select(x => new UserProfileViewModel
                {
                     Id = x.Id,
                     FirstName = x.FirstName,
                     LastName = x.LastName,
                     AccessToken = x.AccessToken,
                     EntryDate = x.EntryDate
                }).ToList();
            }
        }
    }
}
