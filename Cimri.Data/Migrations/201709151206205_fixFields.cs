namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyInfoes", "IsSupplier", c => c.Boolean(nullable: false));
            AddColumn("dbo.CompanyInfoes", "IsCustomer", c => c.Boolean(nullable: false));
            DropColumn("dbo.CompanyInfoes", "Supplier");
            DropColumn("dbo.CompanyInfoes", "Customer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CompanyInfoes", "Customer", c => c.Boolean(nullable: false));
            AddColumn("dbo.CompanyInfoes", "Supplier", c => c.Boolean(nullable: false));
            DropColumn("dbo.CompanyInfoes", "IsCustomer");
            DropColumn("dbo.CompanyInfoes", "IsSupplier");
        }
    }
}
