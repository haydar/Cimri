namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stock_active : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stocks", "isActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stocks", "isActive");
        }
    }
}
