namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_AdressDistrict : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyInfoes", "AdressDistrict", c => c.String());
            AddColumn("dbo.UserCompanies", "AdressDistrict", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserCompanies", "AdressDistrict");
            DropColumn("dbo.CompanyInfoes", "AdressDistrict");
        }
    }
}
