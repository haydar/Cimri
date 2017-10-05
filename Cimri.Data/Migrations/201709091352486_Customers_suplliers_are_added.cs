namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customers_suplliers_are_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyInfoes", "Suppliers", c => c.Boolean(nullable: false));
            AddColumn("dbo.CompanyInfoes", "Customer", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CompanyInfoes", "Customer");
            DropColumn("dbo.CompanyInfoes", "Suppliers");
        }
    }
}
