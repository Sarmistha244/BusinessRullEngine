using ProductClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryClassLibrary
{
   public class ConcreteProduct : BusinessFactory
    {
        public override IBook CreateBook()
        {
            return new Book();
        }
        public override IMemberShip CreateMembership()
        {
            return new Membershp();
        }
        public override IPhysicalProduct CreatePhysicalProduct()
        {
            return new PhysicalProduct();
        }
        public override IUpgradeMembershp CreateUpgradeMembershp()
        {
            return new UpgradeMembershp();
        }
    }
}
