using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Receipt
{
    public class OriginalReceipt : IReceipt
    {
        public string GenerateRecipt()
        {
            return "Generating original recipt";
        }
    }
}
