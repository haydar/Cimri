namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Minor_Changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductTransactions", "UserCompany_UserCompanyId", c => c.Int());
            CreateIndex("dbo.ProductTransactions", "UserCompany_UserCompanyId");
            AddForeignKey("dbo.ProductTransactions", "UserCompany_UserCompanyId", "dbo.UserCompanies", "UserCompanyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTransactions", "UserCompany_UserCompanyId", "dbo.UserCompanies");
            DropIndex("dbo.ProductTransactions", new[] { "UserCompany_UserCompanyId" });
            DropColumn("dbo.ProductTransactions", "UserCompany_UserCompanyId");
        }
    }
}
