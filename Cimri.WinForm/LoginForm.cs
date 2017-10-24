using Cimri.Business;
using Cimri.Entity;
using Cimri.Entity.DTO;
using Cimri.WinForm.Classes;
using MetroFramework;
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

namespace Cimri.WinForm
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public int companyId;

        UserCompanyBusiness bUserCompany = new UserCompanyBusiness();
        ProgramUserBusiness bProgramUser = new ProgramUserBusiness();
        private void LoginForm_Load(object sender, EventArgs e)
        {
            #region FillcomboBox_UserCompany
            foreach (var item in bUserCompany.BringAll())
            {
                mcbxUserCompany.Items.Add(item.UserCompanyId + "- " + item.Title);
            }
            mcbxUserCompany.SelectedIndex = 0;
            #endregion
            this.BringToFront();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginTransactions login = new LoginTransactions();
            login.VerifyUser();
        }
    }
}
