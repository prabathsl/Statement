namespace Stock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        Email = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        FailedLogins = c.Int(nullable: false),
                        LastLoggedIp = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastLoggedDateTime = c.DateTime(nullable: false),
                        IsLocked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
