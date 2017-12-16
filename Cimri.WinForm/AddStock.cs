using Cimri.WinForm.Classes;
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
    public partial class AddStockForm : BaseForm
    {
        public AddStockForm()
        {
            InitializeComponent();
        }
        MainForm mainForm;
        private void AddStock_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)Application.OpenForms["MainForm"];
        }

        private void AddStock_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                mainForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            ProductTransactions productTransactions = new ProductTransactions();
            productTransactions.AddStock();
        }

        private void AddStockForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void mtxtStockStartingCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtxtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char firstLetter=' ';
            char tmpLetter=' ';
            try
            {
                tmpLetter = mtxtUnitPrice.Text[mtxtUnitPrice.Text.Length-1];
                firstLetter= mtxtUnitPrice.Text[0];
            }
            catch (Exception)
            {
            }

            bool isKeyNumericOrDot = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                && e.KeyChar != '.' || 
                (tmpLetter == '.' && e.KeyChar == '.');
        }
    }
}
