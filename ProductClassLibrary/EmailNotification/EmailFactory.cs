using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.EmailNotification
{
   public class EmailFactory
    {
        public static IEmail EmailFact(string emailType)
        {
            //We can impliment dependancy injection here as well if there is multiple class which is going to impliment IEmail interface
            //we can resolve it from the container at run time
            return new Email();
        }
    }
}
