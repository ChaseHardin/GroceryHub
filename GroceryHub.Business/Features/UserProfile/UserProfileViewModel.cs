using System;

namespace GroceryHub.Business.Features.UserProfile
{
    public class UserProfileViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EntryDate { get; set; }
        public Guid AccessToken { get; set; }
    }
}
