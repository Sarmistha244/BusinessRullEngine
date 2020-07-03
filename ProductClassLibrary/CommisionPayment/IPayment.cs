using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.CommisionPayment
{
   public interface IPayment
    {
        string GenerateComission();
    }
}
