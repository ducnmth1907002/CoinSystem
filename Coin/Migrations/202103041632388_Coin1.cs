namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coin1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.News", "UserId");
            DropColumn("dbo.Subscribes", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subscribes", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.News", "UserId", c => c.Int(nullable: false));
        }
    }
}
