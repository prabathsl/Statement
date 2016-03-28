using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Model
{
    public class OperationResult
    {
        public string Message { get; set; }
        public bool IsSucess { get; set; }

        public OperationResult(bool sucess,string message)
        {
            Message = message;
            IsSucess = sucess;
        }
    }
}
