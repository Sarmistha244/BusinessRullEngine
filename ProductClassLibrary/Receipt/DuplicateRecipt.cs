using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Receipt
{
    public class DuplicateRecipt: IReceipt
    {
        public string GenerateRecipt()
        {
            return "Generating Duplicate recipt";
        }
    }
}
