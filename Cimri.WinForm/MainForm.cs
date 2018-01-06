using Cimri.Business;
using Cimri.Entity;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cimri.Entity.DTO;
using Cimri.WinForm.Classes;

namespace Cimri.WinForm
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        CompanyTransactions company = new CompanyTransactions();
        ProductTransactions product = new ProductTransactions();
        LoginForm Form = (LoginForm)Application.OpenForms["LoginForm"];
        CompanyInfoBusiness BCompanyInfo = new CompanyInfoBusiness();
        public int companyId;
        public int userCompanyId=1;
        public bool firstRunned=true;

        private void MainForm_Load(object sender, EventArgs e)
        {
            mtpCompanies.Show();
            CompanyTransactions company = new CompanyTransactions();
            company.FillCompaniesToDataGrid(userCompanyId);
            product.FillProductsToDataGrid(userCompanyId);
            companyId = Convert.ToInt32(mdgCompanies[0, mdgCompanies.CurrentCell.RowIndex].Value);
            company.ShowCompanyDetails();
            //mlbl_Username.Text ="Sayın, "+ Form.userRealName.ToString(); 
            firstRunned = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CompanyTransactions company = new CompanyTransactions();
            company.UpdateCompany();
        }

        private void mgdCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            companyId = Convert.ToInt32(mdgCompanies[0, mdgCompanies.CurrentCell.RowIndex].Value);
            CompanyTransactions company= new CompanyTransactions();
            company.ShowCompanyDetails();
        }
        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            AddCompanyForm _addCompany=new AddCompanyForm();
            _addCompany.ShowDialog();
        }

        private void mtxtTaxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtxtTradeRegistryNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mdgCompanies_KeyUp(object sender, KeyEventArgs e)
        {
            companyId = Convert.ToInt32(mdgCompanies[0, mdgCompanies.CurrentCell.RowIndex].Value);
            CompanyTransactions company = new CompanyTransactions();
            company.ShowCompanyDetails();
        }

        private void mdgCompanies_KeyDown(object sender, KeyEventArgs e)
        {
            companyId = Convert.ToInt32(mdgCompanies[0, mdgCompanies.CurrentCell.RowIndex].Value);
            CompanyTransactions company = new CompanyTransactions();
            company.ShowCompanyDetails();
        }

        private void btnBringAll_Click(object sender, EventArgs e)
        {
            CompanyTransactions company = new CompanyTransactions();
            company.FillCompaniesToDataGrid(userCompanyId);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CompanyTransactions company = new CompanyTransactions();
            company.Search();
        }

        private void mtxtTitle_TextChanged(object sender, EventArgs e)
        {
            CompanyTransactions company = new CompanyTransactions();
            company.Search();
        }

        private void mtxtTel_TextChanged(object sender, EventArgs e)
        {
            CompanyTransactions company = new CompanyTransactions();
            company.Search();
        }

        private void mcboxCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (!firstRunned)
            {
                CompanyTransactions company = new CompanyTransactions();
                company.Search();
            }
          
        }

        private void mcboxSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (!firstRunned)
            {
                CompanyTransactions company = new CompanyTransactions();
                company.Search();
            }
        }

        private void mcboxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (!firstRunned)
            {
                CompanyTransactions company = new CompanyTransactions();
                company.Search();
            }
        }

        private void mcboxPassive_CheckedChanged(object sender, EventArgs e)
        {
            if (!firstRunned)
            {
                CompanyTransactions company = new CompanyTransactions();
                company.Search();
            }
        }

        private void btnPrintCachedCompanyInfo_Click(object sender, EventArgs e)
        {
            CompanyTransactions company = new CompanyTransactions();
            company.PrintCachedCompanyInfo();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddStockForm addStockForm = new AddStockForm();
            addStockForm.ShowDialog();
        }

        private void btnBringAllStock_Click(object sender, EventArgs e)
        {
            ProductTransactions productTransactions = new ProductTransactions();
            productTransactions.FillProductsToDataGrid(userCompanyId);
        }

    }
}
