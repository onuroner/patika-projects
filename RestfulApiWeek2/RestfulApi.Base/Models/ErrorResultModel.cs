using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulApi.Base.Models
{
    public class ErrorResultModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
