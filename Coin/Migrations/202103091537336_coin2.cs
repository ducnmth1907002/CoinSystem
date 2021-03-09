namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coin2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscribes", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Subscribes", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subscribes", "MyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Subscribes", "Status");
        }
    }
}
