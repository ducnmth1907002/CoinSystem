namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscribes", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscribes", "Code");
        }
    }
}
