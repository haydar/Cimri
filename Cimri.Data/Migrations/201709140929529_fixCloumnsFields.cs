namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixCloumnsFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyInfoes", "AddressCity", c => c.String());
            AddColumn("dbo.CompanyInfoes", "AddressDistrict", c => c.String());
            AddColumn("dbo.CompanyInfoes", "AddressFloor", c => c.String());
            DropColumn("dbo.CompanyInfoes", "AdressCity");
            DropColumn("dbo.CompanyInfoes", "AdressDistrict");
            DropColumn("dbo.CompanyInfoes", "AdressFloor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CompanyInfoes", "AdressFloor", c => c.String());
            AddColumn("dbo.CompanyInfoes", "AdressDistrict", c => c.String());
            AddColumn("dbo.CompanyInfoes", "AdressCity", c => c.String());
            DropColumn("dbo.CompanyInfoes", "AddressFloor");
            DropColumn("dbo.CompanyInfoes", "AddressDistrict");
            DropColumn("dbo.CompanyInfoes", "AddressCity");
        }
    }
}
