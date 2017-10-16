using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity.DTO
{
    public class ErrorDto
    {
        public bool ProcessResult { get; set; } = false;
        public string Description { get; set; } = "";
        public string ErrorMessage { get; set; } = "";

        public ErrorDto()
        {
            ProcessResult = false;
            Description = "";
            ErrorMessage = "";
        }
    }
}
