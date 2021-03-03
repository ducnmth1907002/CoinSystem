namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TenCuaMigrate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Currencies", "CreatedAt", c => c.DateTime());
            AlterColumn("dbo.Currencies", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.News", "CreatedAt", c => c.DateTime());
            AlterColumn("dbo.News", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.Users", "CreatedAt", c => c.DateTime());
            AlterColumn("dbo.Users", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.Subscribes", "CreatedAt", c => c.DateTime());
            AlterColumn("dbo.Subscribes", "UpdatedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subscribes", "UpdatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Subscribes", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "UpdatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.News", "UpdatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.News", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Currencies", "UpdatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Currencies", "CreatedAt", c => c.DateTime(nullable: false));
        }
    }
}
