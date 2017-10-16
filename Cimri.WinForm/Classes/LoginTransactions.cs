using Cimri.Business;
using Cimri.Entity;
using Cimri.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cimri.WinForm.Classes
{
    public class LoginTransactions
    {
        LoginForm loginForm;
        MainForm mainForm;
        public LoginTransactions()
        {
            loginForm = (LoginForm)Application.OpenForms["LoginForm"];
            mainForm = (MainForm)Application.OpenForms["MainForm"];
        }


        ProgramUserBusiness bProgramUser = new ProgramUserBusiness();
        public void VerifyUser()
        {
            if (CheckRequiredVerifyUserFields())
            {
                VerifyUserDto loginRequestInfo = new VerifyUserDto();

                loginRequestInfo.GivenUsername = loginForm.mtxtUsername.Text;
                loginRequestInfo.GivenPassword = loginForm.mtxtPassword.Text;
                string[] splitCompanyName = loginForm.mcbxUserCompany.SelectedItem.ToString().Split('-');
                loginRequestInfo.GivenUserCompanyId = int.Parse(splitCompanyName[0]);

                bProgramUser.VerifyUser(ref loginRequestInfo, out ProgramUser loggedInUser, out ErrorDto error);
                if (error.ProcessResult)
                {
                    mainForm.mlbl_Username.Text = loggedInUser.UserRealName;

                    MainForm _MainForm = new MainForm();
                    _MainForm.Show();
                    loginForm.Hide();
                }
                Error.Show(error);
            }
        }

        public bool CheckRequiredVerifyUserFields()
        {
            string emptyFields = String.Empty;
            if (string.IsNullOrEmpty(loginForm.mtxtUsername.Text))
                emptyFields += "Kullanıcı Adı \n";
            if (string.IsNullOrEmpty(loginForm.mtxtPassword.Text))
                emptyFields += "Şifre \n";

            if (string.IsNullOrEmpty(emptyFields))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Aşağıdaki alanlar boş geçilemezler. \n" + emptyFields, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}
