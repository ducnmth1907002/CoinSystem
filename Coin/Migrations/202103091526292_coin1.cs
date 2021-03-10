namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coin1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscribes", "MyProperty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscribes", "MyProperty");
        }
    }
}
