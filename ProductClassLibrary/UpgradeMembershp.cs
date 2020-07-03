using ProductClassLibrary.EmailNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary
{
   public class UpgradeMembershp:IUpgradeMembershp
    {
        IEmail email;
        public void Upgrade()
        {
            List<string> msg = new List<string>();
            email = EmailFactory.EmailFact("emailType");
            Console.WriteLine(email.SendEmail());
            Console.WriteLine("membership updated");
           

        }
    }
}
