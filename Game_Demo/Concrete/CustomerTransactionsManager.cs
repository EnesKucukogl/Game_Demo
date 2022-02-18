using Game_Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Demo.Concrete
{
    public class CustomerTransactionsManager : ICustomerTransactionsService
    {
        public void Delete(Customers customer)
        {
            Console.WriteLine("User deleted: "+customer.FirstName);
        }

        public void Update(Customers customer)
        {
            Console.WriteLine("User updated: "+ customer.FirstName);
        }
    }
}
