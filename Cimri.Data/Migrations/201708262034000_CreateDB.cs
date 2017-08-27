namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanyInfoes",
                c => new
                    {
                        CompanyInfoId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AdressCity = c.String(),
                        AddressNeighborhood = c.String(),
                        AddressStreet = c.String(),
                        AddressNo = c.String(),
                        AdressFloor = c.String(),
                        TaxNo = c.String(),
                        TaxAdministration = c.String(),
                        AuthorizedPerson = c.String(),
                        AuthorizedPersonGender = c.Boolean(nullable: false),
                        Tel = c.String(),
                        Fax = c.String(),
                        Mail = c.String(),
                        TradeRegistryNo = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        UserCompany_UserCompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.CompanyInfoId)
                .ForeignKey("dbo.UserCompanies", t => t.UserCompany_UserCompanyId)
                .Index(t => t.UserCompany_UserCompanyId);
            
            CreateTable(
                "dbo.FinancialTransactions",
                c => new
                    {
                        FinancialTransactionId = c.Int(nullable: false, identity: true),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionDescription = c.String(),
                        Note = c.String(),
                        Debt = c.Double(nullable: false),
                        Paid = c.Double(nullable: false),
                        CompanyInfo_CompanyInfoId = c.Int(),
                        UserCompany_UserCompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.FinancialTransactionId)
                .ForeignKey("dbo.CompanyInfoes", t => t.CompanyInfo_CompanyInfoId)
                .ForeignKey("dbo.UserCompanies", t => t.UserCompany_UserCompanyId)
                .Index(t => t.CompanyInfo_CompanyInfoId)
                .Index(t => t.UserCompany_UserCompanyId);
            
            CreateTable(
                "dbo.UserCompanies",
                c => new
                    {
                        UserCompanyId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AdressCity = c.String(),
                        AdressNeighborhood = c.String(),
                        AdressStreet = c.String(),
                        AdressNo = c.String(),
                        AdressFloor = c.String(),
                        TaxNo = c.String(),
                        TaxAdministration = c.String(),
                        LogoPath = c.String(),
                        Tel = c.String(),
                        Fax = c.String(),
                        Mail = c.String(),
                        TradeRegistryNo = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserCompanyId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        InvoiceDate = c.DateTime(nullable: false),
                        InvoiceDetailProductId = c.Int(),
                        InvoiceDetailServiceId = c.Int(),
                        CompanyInfo_CompanyInfoId = c.Int(),
                        UserCompany_UserCompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.InvoiceId)
                .ForeignKey("dbo.CompanyInfoes", t => t.CompanyInfo_CompanyInfoId)
                .ForeignKey("dbo.UserCompanies", t => t.UserCompany_UserCompanyId)
                .Index(t => t.CompanyInfo_CompanyInfoId)
                .Index(t => t.UserCompany_UserCompanyId);
            
            CreateTable(
                "dbo.InvoiceDetailProducts",
                c => new
                    {
                        InvoiceDetailProductId = c.Int(nullable: false, identity: true),
                        ProductFee = c.Double(nullable: false),
                        ProductNumber = c.Int(nullable: false),
                        Product_StockId = c.Int(),
                        Invoice_InvoiceId = c.Int(),
                    })
                .PrimaryKey(t => t.InvoiceDetailProductId)
                .ForeignKey("dbo.Stocks", t => t.Product_StockId)
                .ForeignKey("dbo.Invoices", t => t.Invoice_InvoiceId)
                .Index(t => t.Product_StockId)
                .Index(t => t.Invoice_InvoiceId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        StockName = c.String(),
                        StockUnit = c.String(),
                        StockNumber = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Description = c.String(),
                        UserCompany_UserCompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.StockId)
                .ForeignKey("dbo.UserCompanies", t => t.UserCompany_UserCompanyId)
                .Index(t => t.UserCompany_UserCompanyId);
            
            CreateTable(
                "dbo.InvoiceDetailServices",
                c => new
                    {
                        InvoiceDetailServiceId = c.Int(nullable: false, identity: true),
                        ServiceFee = c.Double(nullable: false),
                        ServiceNumber = c.Int(nullable: false),
                        InvoiceId = c.Int(),
                        Service_ServiceId = c.Int(),
                    })
                .PrimaryKey(t => t.InvoiceDetailServiceId)
                .ForeignKey("dbo.Services", t => t.Service_ServiceId)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId)
                .Index(t => t.InvoiceId)
                .Index(t => t.Service_ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        ServiceFee = c.Double(nullable: false),
                        Description = c.String(),
                        UserCompany_UserCompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.ServiceId)
                .ForeignKey("dbo.UserCompanies", t => t.UserCompany_UserCompanyId)
                .Index(t => t.UserCompany_UserCompanyId);
            
            CreateTable(
                "dbo.PeriodicServices",
                c => new
                    {
                        PeriodicServiceId = c.Int(nullable: false, identity: true),
                        ServiceFee = c.Double(nullable: false),
                        ServicePeriodDay = c.Int(nullable: false),
                        PeriodicServiceCreatedDate = c.DateTime(nullable: false),
                        NextServiceDate = c.DateTime(nullable: false),
                        LastServiceDateByAgreement = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        ServiceAgreementPath = c.String(),
                        CompanyInfo_CompanyInfoId = c.Int(),
                        Service_ServiceId = c.Int(),
                        UserCompany_UserCompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.PeriodicServiceId)
                .ForeignKey("dbo.CompanyInfoes", t => t.CompanyInfo_CompanyInfoId)
                .ForeignKey("dbo.Services", t => t.Service_ServiceId)
                .ForeignKey("dbo.UserCompanies", t => t.UserCompany_UserCompanyId)
                .Index(t => t.CompanyInfo_CompanyInfoId)
                .Index(t => t.Service_ServiceId)
                .Index(t => t.UserCompany_UserCompanyId);
            
            CreateTable(
                "dbo.PeriodicServiceHistories",
                c => new
                    {
                        PeriodicServiceHistoryId = c.Int(nullable: false, identity: true),
                        ServiceDate = c.DateTime(nullable: false),
                        ServiceFee = c.Double(nullable: false),
                        PeriodicService_PeriodicServiceId = c.Int(),
                    })
                .PrimaryKey(t => t.PeriodicServiceHistoryId)
                .ForeignKey("dbo.PeriodicServices", t => t.PeriodicService_PeriodicServiceId)
                .Index(t => t.PeriodicService_PeriodicServiceId);
            
            CreateTable(
                "dbo.ProgramUsers",
                c => new
                    {
                        ProgramUserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserRealName = c.String(),
                        UserPassword = c.String(),
                        UserMail = c.String(),
                    })
                .PrimaryKey(t => t.ProgramUserId);
            
            CreateTable(
                "dbo.ProgramUserUserCompanies",
                c => new
                    {
                        ProgramUser_ProgramUserId = c.Int(nullable: false),
                        UserCompany_UserCompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProgramUser_ProgramUserId, t.UserCompany_UserCompanyId })
                .ForeignKey("dbo.ProgramUsers", t => t.ProgramUser_ProgramUserId, cascadeDelete: true)
                .ForeignKey("dbo.UserCompanies", t => t.UserCompany_UserCompanyId, cascadeDelete: true)
                .Index(t => t.ProgramUser_ProgramUserId)
                .Index(t => t.UserCompany_UserCompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProgramUserUserCompanies", "UserCompany_UserCompanyId", "dbo.UserCompanies");
            DropForeignKey("dbo.ProgramUserUserCompanies", "ProgramUser_ProgramUserId", "dbo.ProgramUsers");
            DropForeignKey("dbo.PeriodicServices", "UserCompany_UserCompanyId", "dbo.UserCompanies");
            DropForeignKey("dbo.PeriodicServices", "Service_ServiceId", "dbo.Services");
            DropForeignKey("dbo.PeriodicServiceHistories", "PeriodicService_PeriodicServiceId", "dbo.PeriodicServices");
            DropForeignKey("dbo.PeriodicServices", "CompanyInfo_CompanyInfoId", "dbo.CompanyInfoes");
            DropForeignKey("dbo.Invoices", "UserCompany_UserCompanyId", "dbo.UserCompanies");
            DropForeignKey("dbo.InvoiceDetailServices", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.InvoiceDetailServices", "Service_ServiceId", "dbo.Services");
            DropForeignKey("dbo.Services", "UserCompany_UserCompanyId", "dbo.UserCompanies");
            DropForeignKey("dbo.InvoiceDetailProducts", "Invoice_InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.InvoiceDetailProducts", "Product_StockId", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "UserCompany_UserCompanyId", "dbo.UserCompanies");
            DropForeignKey("dbo.Invoices", "CompanyInfo_CompanyInfoId", "dbo.CompanyInfoes");
            DropForeignKey("dbo.FinancialTransactions", "UserCompany_UserCompanyId", "dbo.UserCompanies");
            DropForeignKey("dbo.CompanyInfoes", "UserCompany_UserCompanyId", "dbo.UserCompanies");
            DropForeignKey("dbo.FinancialTransactions", "CompanyInfo_CompanyInfoId", "dbo.CompanyInfoes");
            DropIndex("dbo.ProgramUserUserCompanies", new[] { "UserCompany_UserCompanyId" });
            DropIndex("dbo.ProgramUserUserCompanies", new[] { "ProgramUser_ProgramUserId" });
            DropIndex("dbo.PeriodicServiceHistories", new[] { "PeriodicService_PeriodicServiceId" });
            DropIndex("dbo.PeriodicServices", new[] { "UserCompany_UserCompanyId" });
            DropIndex("dbo.PeriodicServices", new[] { "Service_ServiceId" });
            DropIndex("dbo.PeriodicServices", new[] { "CompanyInfo_CompanyInfoId" });
            DropIndex("dbo.Services", new[] { "UserCompany_UserCompanyId" });
            DropIndex("dbo.InvoiceDetailServices", new[] { "Service_ServiceId" });
            DropIndex("dbo.InvoiceDetailServices", new[] { "InvoiceId" });
            DropIndex("dbo.Stocks", new[] { "UserCompany_UserCompanyId" });
            DropIndex("dbo.InvoiceDetailProducts", new[] { "Invoice_InvoiceId" });
            DropIndex("dbo.InvoiceDetailProducts", new[] { "Product_StockId" });
            DropIndex("dbo.Invoices", new[] { "UserCompany_UserCompanyId" });
            DropIndex("dbo.Invoices", new[] { "CompanyInfo_CompanyInfoId" });
            DropIndex("dbo.FinancialTransactions", new[] { "UserCompany_UserCompanyId" });
            DropIndex("dbo.FinancialTransactions", new[] { "CompanyInfo_CompanyInfoId" });
            DropIndex("dbo.CompanyInfoes", new[] { "UserCompany_UserCompanyId" });
            DropTable("dbo.ProgramUserUserCompanies");
            DropTable("dbo.ProgramUsers");
            DropTable("dbo.PeriodicServiceHistories");
            DropTable("dbo.PeriodicServices");
            DropTable("dbo.Services");
            DropTable("dbo.InvoiceDetailServices");
            DropTable("dbo.Stocks");
            DropTable("dbo.InvoiceDetailProducts");
            DropTable("dbo.Invoices");
            DropTable("dbo.UserCompanies");
            DropTable("dbo.FinancialTransactions");
            DropTable("dbo.CompanyInfoes");
        }
    }
}
