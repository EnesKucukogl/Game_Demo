using Game_Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Demo.Concrete
{
    public class CustomerManager: BaseCustomerManager
    {
        public ICustomerCheckService _customerCheck;
        public CustomerManager (ICustomerCheckService checkService)
        {
            _customerCheck = checkService;
        }
        public override void Add(Customers customer)
        {
            if (_customerCheck.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                Console.WriteLine("information is wrong");
            }
        }



    }
}
