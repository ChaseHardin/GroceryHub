using System;
using System.Data.Entity.ModelConfiguration;

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

    internal class UserProfileConfiguration : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired();
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired();
            Property(x => x.LastName).HasColumnName("LastName").IsRequired();
            Property(x => x.EntryDate).HasColumnName("EntryDate").IsRequired();
            Property(x => x.AccessToken).HasColumnName("AccessToken").IsRequired();
        }
    }
}