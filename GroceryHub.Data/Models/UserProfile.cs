using System;

namespace GroceryHub.Data.Models
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EntryDate { get; set; }
        public Guid AccessToken { get; set; }
    }
}