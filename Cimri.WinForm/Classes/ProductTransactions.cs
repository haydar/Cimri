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
    public class ProductTransactions
    {
        MainForm mainForm;
        AddStockForm addStockForm;
        public ProductTransactions()
        {
            mainForm = (MainForm)Application.OpenForms["MainForm"];
            addStockForm = (AddStockForm)Application.OpenForms["AddStockForm"];
        }
        StockBusiness bStock = new StockBusiness();
        public void FillProductsToDataGrid(int userCompanyId)
        {
            /*This line is block null exception for when filling DataGrid.*/
            mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm.mdgProducts.DataSource = new StockDto.StockHeader();
            ICollection<StockDto.StockHeader> products = bStock.FillDataGrid(userCompanyId, out ErrorDto error);
            if (error.ProcessResult)
            {
                mainForm.mdgProducts.DataSource = products;
            }
            else
            {
                Error.Show(error);
            }
        }
        public void AddStock(/*out ErrorDto error*/)
        {
            Stock newStock = new Stock();

            if (CheckAddStockFields())
            {
                newStock.StockName = addStockForm.mtxtStockName.Text;
                newStock.CurrentUnitPrice = Convert.ToDouble(addStockForm.mtxtUnitPrice.Text);
                newStock.Description = addStockForm.mtxtStockDescription.Text;
                newStock.UserCompanyId = mainForm.userCompanyId;

                if (addStockForm.mtxtStockStartingCount.Text!="0")
                {
                    ProductTransaction newProductTransaction = new ProductTransaction();

                    newProductTransaction.ProductNumber = int.Parse(addStockForm.mtxtStockStartingCount.Text);
                    newProductTransaction.Date = DateTime.Now;
                    newProductTransaction.UnitPrice = int.Parse(addStockForm.mtxtUnitPrice.Text);
                    newProductTransaction.Description = addStockForm.mtxtStockDescription.Text;

                    newStock.ProductTransactions.Add(newProductTransaction);

                }
                
                bStock.Add(newStock, out ErrorDto error);

                if (error.ProcessResult)
                {
                    addStockForm.Close();
                    MessageBox.Show("Stok Ekleme Başarılı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillProductsToDataGrid(mainForm.userCompanyId);
                }
                else
                {
                    Error.Show(error);
                }
               

            }
        }

        public bool CheckAddStockFields()
        {
            string emptyFields = string.Empty;
            if (string.IsNullOrEmpty(addStockForm.mtxtStockName.Text))
                emptyFields += "Stok Adı \n";
            if (string.IsNullOrEmpty(addStockForm.mtxtUnitPrice.Text))
                emptyFields += "Birim Fiyatı \n";
            if (string.IsNullOrEmpty(addStockForm.mtxtStockStartingCount.Text))
                addStockForm.mtxtStockStartingCount.Text = "0";
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
