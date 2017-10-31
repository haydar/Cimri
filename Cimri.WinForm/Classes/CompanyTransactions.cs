using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cimri.WinForm;
using System.Windows.Forms;
using Cimri.Business;
using Cimri.Entity;
using Cimri.Entity.DTO;

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
        public static CompanyInfo cachedCurrentCompany = new CompanyInfo();

        /*This variable is for permission of showing selected company's details for without change control*/
        bool acceptWithoutUpdateChangesOfCompany=false;

        public void CheckRequiredSearchFields()
        {
            
           
        }
        public void Search()
        {
            string companyTel = string.Empty;
            string companyTitle = string.Empty;
            if (string.IsNullOrEmpty(mainForm.mtxtTitle.Text))
                companyTitle =string.Empty;
            else
            {
                companyTitle = mainForm.mtxtTitle.Text;
            }
            for (int telIndex = 0; telIndex < mainForm.mtxtTel.Text.Length; telIndex++)
            {
                if (char.IsDigit(mainForm.mtxtTel.Text[telIndex]))
                {
                    companyTel = mainForm.mtxtTel.Text;
                }
                else
                {
                    companyTel = string.Empty;
                }
            }                
           
            CompanyInfoDto.Search searchParameters = new CompanyInfoDto.Search();
            searchParameters.Title = companyTitle;
            searchParameters.Tel = companyTel;
            searchParameters.UserCompanyId = mainForm.userCompanyId;
            searchParameters.IsActive = mainForm.mcboxActive.Checked;
            searchParameters.IsCustomer = mainForm.mcboxCustomer.Checked;
            searchParameters.IsSupplier = mainForm.mcboxSupplier.Checked;
            ICollection<CompanyInfoDto.CompanyHeader> header = bCompanyInfo.Search(searchParameters, out ErrorDto error);
            if (error.ProcessResult)
            {
                mainForm.mdgCompanies.DataSource = header;
            }
            else
            {
                Error.Show(error);
            }
        }
        public bool NoDataHasChangedinCompanyDetails()
        {
            CompanyInfo currentCompany = new CompanyInfo();
            currentCompany.Title = mainForm.mtxtDetailTitle.Text;
            currentCompany.AddressCity = mainForm.mtxtCity.Text;
            currentCompany.AddressDistrict = mainForm.mtxtDistrict.Text;
            currentCompany.AddressNeighborhood = mainForm.mtxtNeighborhood.Text;
            currentCompany.AddressStreet = mainForm.mtxtStreet.Text;
            currentCompany.AddressNo = mainForm.mtxtAdressNo.Text;
            currentCompany.AddressFloor = mainForm.mtxtFloor.Text;
            currentCompany.TaxNo = mainForm.mtxtTaxNo.Text;
            currentCompany.TaxAdministration = mainForm.mtxtTaxAdministration.Text;
            currentCompany.AuthorizedPerson = mainForm.mtxtAuthorizedPerson.Text;
            currentCompany.AuthorizedPersonGender = mainForm.mrdbtnMale.Checked ? true : false;
            currentCompany.Tel = mainForm.mtxtDetailTel.Text;
            currentCompany.Fax = mainForm.mtxtDetailFax.Text;
            currentCompany.Mail = mainForm.mtxtMail.Text;
            currentCompany.TradeRegistryNo = mainForm.mtxtTradeRegistryNo.Text;
            currentCompany.CreateDate = mainForm.mdtimeCreateDate.Value;
            currentCompany.IsActive = mainForm.mrdbtnActive.Checked ? true : false;
            currentCompany.Iban = mainForm.mtxtIban.Text;
            currentCompany.IsSupplier = mainForm.mcboxSupplier.Checked ? true : false;
            currentCompany.IsCustomer = mainForm.mcboxCustomer.Checked ? true : false;

            return bCompanyInfo.Compare(cachedCurrentCompany,currentCompany);
            
        }
        public void cacheCompany()
        {
            cachedCurrentCompany.Title = mainForm.mtxtDetailTitle.Text;
            cachedCurrentCompany.AddressCity = mainForm.mtxtCity.Text;
            cachedCurrentCompany.AddressDistrict = mainForm.mtxtDistrict.Text;
            cachedCurrentCompany.AddressNeighborhood = mainForm.mtxtNeighborhood.Text;
            cachedCurrentCompany.AddressStreet = mainForm.mtxtStreet.Text;
            cachedCurrentCompany.AddressNo = mainForm.mtxtAdressNo.Text;
            cachedCurrentCompany.AddressFloor = mainForm.mtxtFloor.Text;
            cachedCurrentCompany.TaxNo = mainForm.mtxtTaxNo.Text;
            cachedCurrentCompany.TaxAdministration = mainForm.mtxtTaxAdministration.Text;
            cachedCurrentCompany.AuthorizedPerson = mainForm.mtxtAuthorizedPerson.Text;
            cachedCurrentCompany.AuthorizedPersonGender = mainForm.mrdbtnMale.Checked ? true : false;
            cachedCurrentCompany.Tel = mainForm.mtxtDetailTel.Text;
            cachedCurrentCompany.Fax = mainForm.mtxtDetailFax.Text;
            cachedCurrentCompany.Mail = mainForm.mtxtMail.Text; 
            cachedCurrentCompany.TradeRegistryNo = mainForm.mtxtTradeRegistryNo.Text;
            cachedCurrentCompany.CreateDate = mainForm.mdtimeCreateDate.Value;
            cachedCurrentCompany.IsActive = mainForm.mrdbtnActive.Checked ? true : false;
            cachedCurrentCompany.Iban = mainForm.mtxtIban.Text;
            cachedCurrentCompany.IsSupplier = mainForm.mcboxSupplier.Checked ? true : false;
            cachedCurrentCompany.IsCustomer = mainForm.mcboxCustomer.Checked ? true : false;
        }
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
                addCompanyForm.Hide();
                MessageBox.Show("Firma Ekleme Başarılı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillCompaniesToDataGrid(mainForm.userCompanyId);
            }
        }    
        public void FillCompaniesToDataGrid(int userCompanyId)
        {
            ICollection<CompanyInfoDto.CompanyHeader> companies = bCompanyInfo.FillDataGrid(userCompanyId, out ErrorDto error);
            if (error.ProcessResult)
            {
                mainForm.mdgCompanies.DataSource = companies;
            }
            else
            {
                Error.Show(error);
            }
        }

        public void UpdateCompany()
        {
            int companyId = int.Parse(mainForm.mlblGivenCompanyId.Text);
            CompanyInfo company = new CompanyInfo();
            company = bCompanyInfo.BringById(companyId);
            if (CheckRequiredUpdateCompanyFields())
            {
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
                company.Fax = mainForm.mtxtDetailFax.Text;
                company.Mail = mainForm.mtxtMail.Text;
                company.TradeRegistryNo = mainForm.mtxtTradeRegistryNo.Text;
                company.CreateDate = mainForm.mdtimeCreateDate.Value;
                company.IsActive = mainForm.mrdbtnActive.Checked ? true : false;
                company.Iban = mainForm.mtxtIban.Text;
                company.IsSupplier = mainForm.mcboxSupplier.Checked ? true : false;
                company.IsCustomer = mainForm.mcboxCustomer.Checked ? true : false;
                bCompanyInfo.Update(company);
                FillCompaniesToDataGrid(mainForm.userCompanyId);
                MessageBox.Show("Firma Güncelleştirme Başarılı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cacheCompany();
            }            
        }

        public void ShowCompanyDetails()
        {    
            if (NoDataHasChangedinCompanyDetails()||acceptWithoutUpdateChangesOfCompany||mainForm.firstRunned)
            {
                CompanyInfo _companyInfo = bCompanyInfo.BringById(mainForm.companyId);
                mainForm.mlblGivenCompanyId.Text = _companyInfo.CompanyInfoId.ToString();
                mainForm.mtxtDetailTitle.Text = _companyInfo.Title;
                mainForm.mtxtCity.Text = _companyInfo.AddressCity;
                mainForm.mtxtDistrict.Text = _companyInfo.AddressDistrict;
                mainForm.mtxtNeighborhood.Text = _companyInfo.AddressNeighborhood;
                mainForm.mtxtStreet.Text = _companyInfo.AddressStreet;
                mainForm.mtxtAdressNo.Text = _companyInfo.AddressNo;
                mainForm.mtxtFloor.Text = _companyInfo.AddressFloor;
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
                cacheCompany();
                acceptWithoutUpdateChangesOfCompany = false;
                mainForm.firstRunned = false;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Değiştirilen firma bilgileri güncellenmedi. Değişiklikleri kaydetmeden  gitmek istiyor musunuz?",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog==DialogResult.Yes)
                {
                    acceptWithoutUpdateChangesOfCompany = true;
                    ShowCompanyDetails();
                }
                
            }
           
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
            if (!mainForm.mtxtDetailTel.MaskFull)
                emptyfields += "- Telefon Numarası";
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
        public bool CheckRequiredUpdateCompanyFields()
        {
            string emptyfields = string.Empty;
            if (string.IsNullOrEmpty(mainForm.mlblAddressCity.Text))
                emptyfields += "- İl\n";
            if (string.IsNullOrEmpty(mainForm.mtxtDistrict.Text))
                emptyfields += "- İlçe\n";
            if (string.IsNullOrEmpty(mainForm.mtxtNeighborhood.Text))
                emptyfields += "- Mahalle\n";
            if (string.IsNullOrEmpty(mainForm.mtxtStreet.Text))
                emptyfields += "- Sokak\n";
            if (string.IsNullOrEmpty(mainForm.mtxtAdressNo.Text))
                emptyfields += "- Kapı No\n";
            if (string.IsNullOrEmpty(mainForm.mtxtFloor.Text))
                emptyfields += "- Kat\n";
            if (string.IsNullOrEmpty(mainForm.mtxtTaxNo.Text))
                emptyfields += "- Vergi No\n";
            if (string.IsNullOrEmpty(mainForm.mtxtTaxAdministration.Text))
                emptyfields += "- Vergi Dairesi\n";
            if (string.IsNullOrEmpty(mainForm.mtxtAuthorizedPerson.Text))
                emptyfields += "- Yetkili Kişi\n";
            if (mainForm.mrdbtnMale.Checked == false &&
                mainForm.mrdbtnFemale.Checked == false)
                emptyfields += "- Cinsiyet\n";
            if (!mainForm.mtxtDetailTel.MaskFull)
                emptyfields += "- Telefon Numarası";
            if (mainForm.mcboxDetailCustomer.Checked == false &&
                mainForm.mcboxDetailSupplier.Checked == false)
                emptyfields += "- Kurum Tipi\n";

            if (string.IsNullOrEmpty(emptyfields))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Aşağıdaki alanlar boş geçilemezler. \n" + emptyfields, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

    }
}
