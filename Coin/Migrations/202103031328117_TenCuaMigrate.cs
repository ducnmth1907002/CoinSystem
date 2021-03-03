namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TenCuaMigrate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Subscribes", "Type", c => c.Int(nullable: false));
            CreateIndex("dbo.News", "UserId");
            AddForeignKey("dbo.News", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "UserId", "dbo.Users");
            DropIndex("dbo.News", new[] { "UserId" });
            DropColumn("dbo.Subscribes", "Type");
            DropColumn("dbo.News", "Type");
        }
    }
}
