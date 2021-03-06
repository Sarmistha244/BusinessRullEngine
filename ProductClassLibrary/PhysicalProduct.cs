﻿using ProductClassLibrary.CommisionPayment;
using ProductClassLibrary.Receipt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary
{
    public class PhysicalProduct: IPhysicalProduct
    {
        private IReceipt recipt;
        private IPayment payment;
        public void GenerateRecipt()
        {
            recipt = ReciptFactory.ReciptFact(ReciptType.original.ToString());
            payment = PaymentFactory.PaymentFact("agent");
            Console.WriteLine(recipt.GenerateRecipt());
            Console.WriteLine(payment.GenerateComission());
        }
    }
}
