using Game_Demo.Abstract;
using Game_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Demo.Concrete
{
    public class CustomerSalesManager : ICustomerSalesService
    {
        public void Invoice(Customers customer)
        {
            Console.WriteLine("Dear "+customer.FirstName+ " we send your invoice to your e-mail address.");
        }

        public void Sales(Games game)
        {
            Console.WriteLine(game.GameName+" Have fun in your game");
        }
    }
}
