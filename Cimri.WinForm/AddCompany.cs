using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cimri.WinForm.Classes;

namespace Cimri.WinForm
{
    public partial class AddCompanyForm : BaseForm
    {
        public AddCompanyForm()
        {
            InitializeComponent();
        }

        MainForm mainForm;
        private void AddCompany_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)Application.OpenForms["MainForm"];
        }

        private void AddCompany_Resize(object sender, EventArgs e)
        {
            if (this.WindowState== FormWindowState.Minimized)
            {
                mainForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            CompanyTransactions company = new CompanyTransactions();
            company.AddCompany();
            
        }

        private void mtxtTaxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
