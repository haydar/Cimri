namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iban_is_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyInfoes", "Iban", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CompanyInfoes", "Iban");
        }
    }
}
