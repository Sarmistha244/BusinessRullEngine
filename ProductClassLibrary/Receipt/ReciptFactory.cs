using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Receipt
{
    public class ReciptFactory
    {
        public static IReceipt ReciptFact(string reciptType)
        {
            //We can impliment dependancy injection here as well if there is multiple class which is going to impliment IEmail interface
            //we can resolve it from the container at run time
            if (reciptType.ToLower().Trim()==ReciptType.original.ToString())
                return new OriginalReceipt();
            else if (reciptType.ToLower().Trim() == ReciptType.duplicate.ToString())
                return new DuplicateRecipt();
            else
            {
                return null;
            }
        }
    }
}
