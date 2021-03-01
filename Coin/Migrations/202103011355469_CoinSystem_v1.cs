namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoinSystem_v1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.News", "UserId");
            AddForeignKey("dbo.News", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "UserId", "dbo.Users");
            DropIndex("dbo.News", new[] { "UserId" });
        }
    }
}
