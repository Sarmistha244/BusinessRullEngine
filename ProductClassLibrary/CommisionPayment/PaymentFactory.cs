using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.CommisionPayment
{
   public class PaymentFactory
    {
        public static IPayment PaymentFact(string payment)
        {
            return new ComissionPayment();
        }
    }
}
