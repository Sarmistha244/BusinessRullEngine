using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.EmailNotification
{
   public class Email:IEmail
    {
        public string SendEmail()
        {
            return "An email has triggered to owner";
        }
    }
}
