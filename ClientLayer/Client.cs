using FactoryClassLibrary;
using ProductClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLayer
{
   public class Client

    {
        private IBook _book;
        private IMemberShip _membership;
        private IPhysicalProduct _physicalproduct;
        private IUpgradeMembershp _upgrademembership;
        private BusinessFactory _factory;
        // Constructor

        public Client()
        {
            _factory = new ConcreteProduct();
            _book = _factory.CreateBook();
            _membership = _factory.CreateMembership();
            _physicalproduct = _factory.CreatePhysicalProduct();
            _upgrademembership = _factory.CreateUpgradeMembershp();
        }

        public void Execute(int type)
        {
            if (type == Convert.ToInt32(ProductType.book))
            {
                _book.GenerateRecipt();
            }
                
            else if (type == Convert.ToInt32(ProductType.membership))
                _membership.Active();
            else if (type == Convert.ToInt32(ProductType.physicalproduct))
                _physicalproduct.GenerateRecipt();
            else if (type == Convert.ToInt32(ProductType.upgrademembership))
                _upgrademembership.Upgrade();
        }
    }
}
