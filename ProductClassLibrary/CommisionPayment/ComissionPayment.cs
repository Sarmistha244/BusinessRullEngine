using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.CommisionPayment
{
   public class ComissionPayment:IPayment
    {
       public string GenerateComission()
        {
            return "generating payment for Agent";
        }
    }
}
