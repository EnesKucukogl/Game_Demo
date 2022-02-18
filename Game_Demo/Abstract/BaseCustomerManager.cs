using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Demo.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customers customer)
        {
            Console.WriteLine("Customer added: "+customer.FirstName);
        }
    }
}
