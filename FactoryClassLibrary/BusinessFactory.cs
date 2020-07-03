using ProductClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryClassLibrary
{
    public abstract class BusinessFactory
    {
        public abstract IBook CreateBook();
        public abstract IMemberShip CreateMembership();
        public abstract IPhysicalProduct CreatePhysicalProduct();
        public abstract IUpgradeMembershp CreateUpgradeMembershp();
    }
}
