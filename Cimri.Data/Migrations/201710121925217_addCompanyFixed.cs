namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCompanyFixed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CompanyInfoes", "UserCompany_UserCompanyId", "dbo.UserCompanies");
            DropIndex("dbo.CompanyInfoes", new[] { "UserCompany_UserCompanyId" });
            RenameColumn(table: "dbo.CompanyInfoes", name: "UserCompany_UserCompanyId", newName: "UserCompanyId");
            AlterColumn("dbo.CompanyInfoes", "UserCompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.CompanyInfoes", "UserCompanyId");
            AddForeignKey("dbo.CompanyInfoes", "UserCompanyId", "dbo.UserCompanies", "UserCompanyId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyInfoes", "UserCompanyId", "dbo.UserCompanies");
            DropIndex("dbo.CompanyInfoes", new[] { "UserCompanyId" });
            AlterColumn("dbo.CompanyInfoes", "UserCompanyId", c => c.Int());
            RenameColumn(table: "dbo.CompanyInfoes", name: "UserCompanyId", newName: "UserCompany_UserCompanyId");
            CreateIndex("dbo.CompanyInfoes", "UserCompany_UserCompanyId");
            AddForeignKey("dbo.CompanyInfoes", "UserCompany_UserCompanyId", "dbo.UserCompanies", "UserCompanyId");
        }
    }
}
