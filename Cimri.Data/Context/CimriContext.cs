using Cimri.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Data.Context
{
    class CimriContext:DbContext
    {
        public CimriContext():base("CimriContext")
        {

        }
        public virtual DbSet<ProgramUser> ProgramUsers { get; set; }
        public virtual DbSet<CompanyInfo> CompanyInfos { get; set; }
        public virtual DbSet<FinancialTransaction> FinancialTransactions { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetailProduct> InvoiceDetailProducts { get; set; }
        public virtual DbSet<InvoiceDetailService> InvoiceDetailServices { get; set; }
        public virtual DbSet<PeriodicService> PeriodicServices { get; set; }
        public virtual DbSet<PeriodicServiceHistory> PeriodicServiceHistories { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<UserCompany> UserCompanies { get; set; }
      
    }
}
