using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cimri.WinForm;
using System.Windows.Forms;
using Cimri.Business;
using Cimri.Entity;


namespace Cimri.WinForm.Classes
{
    public class CompanyTransactions
    {
        MainForm mainForm;
        AddCompanyForm addCompanyForm;
        public CompanyTransactions()
        {
            mainForm = (MainForm)Application.OpenForms["MainForm"];      
            addCompanyForm= (AddCompanyForm)Application.OpenForms["AddCompanyForm"];
        }

        CompanyInfoBusiness bCompanyInfo = new CompanyInfoBusiness();
        UserCompanyBusiness bUserCompany=new UserCompanyBusiness();

        public void AddCompany()
        {
            if (CheckRequiredAddCompanyFields())
            {
                CompanyInfo newCompany = new CompanyInfo();
                newCompany.Title = addCompanyForm.mtxtDetailTitle.Text;
                newCompany.AddressCity = addCompanyForm.mtxtCity.Text;
                newCompany.AddressDistrict = addCompanyForm.mtxtDistrict.Text;
                newCompany.AddressNeighborhood = addCompanyForm.mtxtNeighborhood.Text;
                newCompany.AddressStreet = addCompanyForm.mtxtStreet.Text;
                newCompany.AddressNo = addCompanyForm.mtxtAdressNo.Text;
                newCompany.AddressFloor = addCompanyForm.mtxtFloor.Text;
                newCompany.TaxNo = addCompanyForm.mtxtTaxNo.Text;
                newCompany.TaxAdministration = addCompanyForm.mtxtTaxAdministration.Text;
                newCompany.AuthorizedPerson = addCompanyForm.mtxtAuthorizedPerson.Text;
                newCompany.AuthorizedPersonGender = addCompanyForm.mrdbtnMale.Checked ? true : false;
                newCompany.Tel = addCompanyForm.mtxtDetailTel.Text;
                newCompany.Fax = addCompanyForm.mtxtDetailFax.Text;
                newCompany.Mail = addCompanyForm.mtxtMail.Text;
                newCompany.TradeRegistryNo = addCompanyForm.mtxtTradeRegistryNo.Text;
                newCompany.CreateDate = DateTime.Now;
                newCompany.IsActive = true;
                newCompany.Iban = addCompanyForm.mtxtIban.Text;
                newCompany.IsCustomer = addCompanyForm.mcboxDetailCustomer.Checked == true ? true : false;
                newCompany.IsSupplier = addCompanyForm.mcboxDetailSupplier.Checked == true ? true: false;

                newCompany.UserCompanyId = mainForm.userCompanyId;

                bCompanyInfo.Add(newCompany);
                
                MessageBox.Show("Firma Ekleme Başarılı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillCompaniesToDataGrid(mainForm.userCompanyId);
            }
        }    
        public void FillCompaniesToDataGrid(int userCompanyId)
        {
            mainForm.mdgCompanies.DataSource = bCompanyInfo.FillDataGrid(userCompanyId, out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
        }

        public void UpdateCompany()
        {
            int companyId = int.Parse(mainForm.mlblGivenCompanyId.Text);
            CompanyInfo company = new CompanyInfo();
            company = bCompanyInfo.BringById(companyId);
            company.Title = mainForm.mtxtDetailTitle.Text;
            company.AddressCity = mainForm.mtxtCity.Text;
            company.AddressDistrict = mainForm.mtxtDistrict.Text;
            company.AddressNeighborhood = mainForm.mtxtNeighborhood.Text;
            company.AddressStreet = mainForm.mtxtStreet.Text;
            company.AddressNo = mainForm.mtxtAdressNo.Text;
            company.AddressFloor = mainForm.mtxtFloor.Text;
            company.TaxNo = mainForm.mtxtTaxNo.Text;
            company.TaxAdministration = mainForm.mtxtTaxAdministration.Text;
            company.AuthorizedPerson = mainForm.mtxtAuthorizedPerson.Text;
            company.AuthorizedPersonGender = mainForm.mrdbtnMale.Checked ? true : false;
            company.Tel = mainForm.mtxtDetailTel.Text;
            company.Fax = mainForm.mtxtMail.Text;
            company.Mail = mainForm.mtxtMail.Text;
            company.TradeRegistryNo = mainForm.mtxtTradeRegistryNo.Text;
            company.CreateDate = mainForm.mdtimeCreateDate.Value;
            company.IsActive = mainForm.mrdbtnActive.Checked ? true : false;
            company.Iban = mainForm.mtxtIban.Text;
            company.IsSupplier = mainForm.mcboxSupplier.Checked ? true : false;
            company.IsCustomer = mainForm.mcboxCustomer.Checked ? true : false;
            bCompanyInfo.Update(company);
            FillCompaniesToDataGrid(3);
            MessageBox.Show("Firma Güncelleştirme Başarılı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowCompanyDetails()
        {
            CompanyInfo _companyInfo = bCompanyInfo.BringById(mainForm.companyId);
            mainForm.mlblGivenCompanyId.Text = _companyInfo.CompanyInfoId.ToString();
            mainForm.mtxtDetailTitle.Text = _companyInfo.Title;
            mainForm.mtxtCity.Text = _companyInfo.AddressCity;
            mainForm.mtxtDistrict.Text = _companyInfo.AddressDistrict;
            mainForm.mtxtNeighborhood.Text = _companyInfo.AddressNeighborhood;
            mainForm.mtxtStreet.Text = _companyInfo.AddressStreet;
            mainForm.mtxtAdressNo.Text = _companyInfo.AddressNo;
            mainForm.mtxtTaxNo.Text = _companyInfo.TaxNo;
            mainForm.mtxtTaxAdministration.Text = _companyInfo.TaxAdministration;
            mainForm.mtxtAuthorizedPerson.Text = _companyInfo.AuthorizedPerson;
            mainForm.mrdbtnMale.Checked = _companyInfo.AuthorizedPersonGender ? true : false;
            mainForm.mrdbtnFemale.Checked = _companyInfo.AuthorizedPersonGender ? false : true;
            mainForm.mtxtDetailTel.Text = _companyInfo.Tel;
            mainForm.mtxtDetailFax.Text = _companyInfo.Fax;
            mainForm.mtxtMail.Text = _companyInfo.Mail;
            mainForm.mtxtTradeRegistryNo.Text = _companyInfo.TradeRegistryNo;
            mainForm.mdtimeCreateDate.Value = _companyInfo.CreateDate;
            mainForm.mrdbtnActive.Checked = _companyInfo.IsActive ? true : false;
            mainForm.mrdbtnPassive.Checked = _companyInfo.IsActive ? false : true;
            mainForm.mtxtIban.Text = _companyInfo.Iban;
            mainForm.mcboxSupplier.Checked = _companyInfo.IsSupplier ? true : false;
            mainForm.mcboxCustomer.Checked = _companyInfo.IsActive ? true : false;        
        }

        public bool CheckRequiredAddCompanyFields()
        {
            string emptyfields = string.Empty;
            if (string.IsNullOrEmpty(addCompanyForm.mtxtDetailTitle.Text))
                emptyfields += "- Ünvan\n";
            if (string.IsNullOrEmpty(addCompanyForm.mlblAddressCity.Text))
                emptyfields += "- İl\n";
            if (string.IsNullOrEmpty(addCompanyForm.mtxtDistrict.Text))
                emptyfields += "- İlçe\n";
            if (string.IsNullOrEmpty(addCompanyForm.mtxtNeighborhood.Text))
                emptyfields += "- Mahalle\n";
            if (string.IsNullOrEmpty(addCompanyForm.mtxtStreet.Text))
                emptyfields += "- Sokak\n";
            if (string.IsNullOrEmpty(addCompanyForm.mtxtAdressNo.Text))
                emptyfields += "- Kapı No\n";
            if (string.IsNullOrEmpty(addCompanyForm.mtxtFloor.Text))
                emptyfields += "- Kat\n";
            if (string.IsNullOrEmpty(addCompanyForm.mtxtTaxNo.Text))
                emptyfields += "- Vergi No\n";
            if (string.IsNullOrEmpty(addCompanyForm.mtxtTaxAdministration.Text))
                emptyfields += "- Vergi Dairesi\n";
            if (string.IsNullOrEmpty(addCompanyForm.mtxtAuthorizedPerson.Text))
                emptyfields += "- Yetkili Kişi\n";
            if (addCompanyForm.mrdbtnMale.Checked == false &&
                addCompanyForm.mrdbtnFemale.Checked == false)
                emptyfields += "- Cinsiyet\n";
            if (string.IsNullOrEmpty(addCompanyForm.mtxtDetailTel.Text))
                emptyfields += "- Tel\n";
            if (addCompanyForm.mcboxDetailCustomer.Checked == false &&
                addCompanyForm.mcboxDetailSupplier.Checked == false)
                emptyfields += "- Kurum Tipi\n";

            if (string.IsNullOrEmpty(emptyfields))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Aşağıdaki alanlar boş geçilemezler. \n"+emptyfields,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }

    }
}
