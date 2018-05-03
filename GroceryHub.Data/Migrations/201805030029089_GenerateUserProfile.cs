namespace GroceryHub.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenerateUserProfile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                        AccessToken = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserProfiles");
        }
    }
}
