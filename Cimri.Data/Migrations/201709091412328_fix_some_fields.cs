namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_some_fields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyInfoes", "Supplier", c => c.Boolean(nullable: false));
            DropColumn("dbo.CompanyInfoes", "Suppliers");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CompanyInfoes", "Suppliers", c => c.Boolean(nullable: false));
            DropColumn("dbo.CompanyInfoes", "Supplier");
        }
    }
}
