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
     
        LoginForm Form = (LoginForm)Application.OpenForms["LoginForm"];
        CompanyInfoBusiness BCompanyInfo = new CompanyInfoBusiness();
        public int companyId;
        public int userCompanyId=1;
        private void MainForm_Load(object sender, EventArgs e)
        {
            CompanyTransactions company = new CompanyTransactions();
            company.FillCompaniesToDataGrid(userCompanyId);
            companyId=Convert.ToInt32(mdgCompanies[0, mdgCompanies.CurrentCell.RowIndex].Value);
            company.ShowCompanyDetails();
            //mlbl_Username.Text ="Sayın, "+ Form.userRealName.ToString();
            
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
    }
}
