using Game_Demo.Abstract;
using Game_Demo.Adapter;
using Game_Demo.Concrete;
using Game_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation; 
            Console.WriteLine("Select operation:");
            Console.WriteLine("1- I want to register\n"+
                "2- I want to delete my information\n"+
                "3- I want to update my information\n"+
                "4- I want to buy game\n");
            
            operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        BaseCustomerManager customer = new CustomerManager(new MernisServiceAdapter());
                        customer.Add(new Customers { Id = 1, NatıonalıtyId = "14294078140", FirstName = "ENES", LastName = "KÜÇÜKOĞLU", DateOfBirth = (new DateTime(2000, 3, 25)) });
                        break;

                    case 2:
                        CustomerTransactionsManager customer1 = new CustomerTransactionsManager();
                        customer1.Delete(new Customers { Id = 1, NatıonalıtyId = "14294078140", FirstName = "ENES", LastName = "KÜÇÜKOĞLU", DateOfBirth = (new DateTime(2000, 3, 25)) });
                        break;

                    case 3:
                        CustomerTransactionsManager customer2 = new CustomerTransactionsManager();
                        customer2.Update(new Customers { Id = 1, NatıonalıtyId = "14294078140", FirstName = "ENES", LastName = "KÜÇÜKOĞLU", DateOfBirth = (new DateTime(2000, 3, 25)) });
                        break;

                    case 4:
                        CustomerSalesManager customerSales = new CustomerSalesManager();
                        customerSales.Invoice(new Customers { FirstName = "ENES" });
                        customerSales.Sales(new Games { GameName = "Mortal Kombat 11 (Ultimate Edition)" });
                        break;
                    default:
                        Console.WriteLine("Wrong dialing!");
                        break;
                }
              
            
         
            Console.ReadLine();
        }

    }

 




}

            

    

