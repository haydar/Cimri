using Cimri.Business;
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
        public ProductTransactions()
        {
            mainForm = (MainForm)Application.OpenForms["MainForm"];
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
            { Error.Show(error); }
        }
    }
}
