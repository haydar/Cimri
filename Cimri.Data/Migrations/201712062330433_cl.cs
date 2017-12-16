namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductTransactions", "TakenBy", c => c.Int());
            AlterColumn("dbo.ProductTransactions", "GivenBy", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductTransactions", "GivenBy", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductTransactions", "TakenBy", c => c.Int(nullable: false));
        }
    }
}
