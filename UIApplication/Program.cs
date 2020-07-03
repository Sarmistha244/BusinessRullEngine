using ClientLayer;
using FactoryClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIApplication
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Please choose the option for payment");
            Console.WriteLine("1)Book, 2)Membership, 3)Physical Product, 4)UpgradeMembership");
            Client client1 = new Client();
            int type =Convert.ToInt32(Console.ReadLine());
            client1.Execute(type);
            Console.ReadKey();
        }
    }
}
