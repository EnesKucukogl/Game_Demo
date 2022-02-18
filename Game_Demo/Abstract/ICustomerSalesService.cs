using Game_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Demo.Abstract
{
    public interface ICustomerSalesService
    {
        void Invoice(Customers customer);
        void Sales(Games game);
    }
}
