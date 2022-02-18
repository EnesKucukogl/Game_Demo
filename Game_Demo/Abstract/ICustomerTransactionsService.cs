using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Demo.Abstract
{
    public interface ICustomerTransactionsService
    {
        void Delete(Customers customer);
        void Update(Customers customer);
    }
}
