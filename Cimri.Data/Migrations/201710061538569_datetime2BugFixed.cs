namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime2BugFixed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CompanyInfoes", "CreateDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.FinancialTransactions", "TransactionDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.UserCompanies", "CreateDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Invoices", "InvoiceDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.PeriodicServices", "PeriodicServiceCreatedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.PeriodicServices", "NextServiceDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.PeriodicServices", "LastServiceDateByAgreement", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.PeriodicServiceHistories", "ServiceDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PeriodicServiceHistories", "ServiceDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PeriodicServices", "LastServiceDateByAgreement", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PeriodicServices", "NextServiceDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PeriodicServices", "PeriodicServiceCreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Invoices", "InvoiceDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserCompanies", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.FinancialTransactions", "TransactionDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CompanyInfoes", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
