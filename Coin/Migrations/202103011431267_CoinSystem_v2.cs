namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoinSystem_v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Subscribes", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscribes", "Type");
            DropColumn("dbo.News", "Type");
        }
    }
}
