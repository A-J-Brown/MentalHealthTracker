namespace MentalHealthTracker.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreationWithEntriesAndUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        EntryId = c.Guid(nullable: false),
                        Date = c.DateTime(),
                        Journal = c.String(),
                        Medication = c.String(),
                        Mood = c.Int(nullable: false),
                        User_UserId = c.Guid(),
                    })
                .PrimaryKey(t => t.EntryId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "User_UserId", "dbo.Users");
            DropIndex("dbo.Entries", new[] { "User_UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Entries");
        }
    }
}
