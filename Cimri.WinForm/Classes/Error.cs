using Cimri.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cimri.WinForm.Classes
{
    public static class Error
    {
        public static void Show(ErrorDto errorInfo) => 
        MessageBox.Show(errorInfo.Description+"\n"+errorInfo.ErrorMessage,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
    }
}
