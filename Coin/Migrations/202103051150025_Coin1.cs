namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coin1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "AuthorId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "AuthorId");
        }
    }
}
