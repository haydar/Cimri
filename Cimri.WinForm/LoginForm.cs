using Cimri.Business;
using Cimri.Entity;
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
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string userRealName;
        public int companyId;

        UserCompanyBusiness UserCompany = new UserCompanyBusiness();
        ProgramUserBusiness ProgramUser = new ProgramUserBusiness();
        private void LoginForm_Load(object sender, EventArgs e)
        {
            #region FillcomboBox_UserCompany
            foreach (var item in UserCompany.BringAll())
            {
                mcbxUserCompany.Items.Add(item.UserCompanyId + "- " + item.Title);
            }
            mcbxUserCompany.SelectedIndex = 0;
            #endregion
            this.BringToFront();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = mtxtUsername.Text;
            string userPassword = mtxtPassword.Text;
            string[] splitCompanyName = mcbxUserCompany.SelectedItem.ToString().Split('-');
            companyId = int.Parse(splitCompanyName[0]);

                ProgramUser.VerifyUser(ref username, ref userPassword, ref companyId, out string error,
                out ProgramUser loggedInUser, out bool isThereError);

            if (isThereError)
                MessageBox.Show(error, "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                userRealName = loggedInUser.UserRealName;
                MainForm _MainForm = new MainForm();
                _MainForm.Show();
                this.Hide();
            }
        }
    }
}
