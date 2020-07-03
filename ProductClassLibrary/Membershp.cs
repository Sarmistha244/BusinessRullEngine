using ProductClassLibrary.EmailNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary
{
    public class Membershp : IMemberShip
    {
        IEmail email;
        public void Active()
        {
            List<string> msg = new List<string>();
            email = EmailFactory.EmailFact("emailType");
            Console.WriteLine(email.SendEmail());
            Console.WriteLine("Activating user");
           

        }
    }
}
