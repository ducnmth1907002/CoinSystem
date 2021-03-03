namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TenCuaMigrate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Currencies", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Currencies", "UpdatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.News", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.News", "UpdatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "UpdatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Subscribes", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Subscribes", "UpdatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscribes", "UpdatedAt");
            DropColumn("dbo.Subscribes", "CreatedAt");
            DropColumn("dbo.Users", "UpdatedAt");
            DropColumn("dbo.Users", "CreatedAt");
            DropColumn("dbo.News", "UpdatedAt");
            DropColumn("dbo.News", "CreatedAt");
            DropColumn("dbo.Currencies", "UpdatedAt");
            DropColumn("dbo.Currencies", "CreatedAt");
        }
    }
}
