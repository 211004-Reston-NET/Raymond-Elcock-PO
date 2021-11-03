using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddCustomers : IMenu
    {
        private static Customers _customers = new Customers();
        private ICustomersBL _customersBL;

        public AddCustomers(ICustomersBL customers)
        {
            _customersBL = customers;
        }
        public void Menu()
        {
            Console.WriteLine("Welcome To Add A Customer! ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Name: {_customers.Name}");
            Console.WriteLine($"Address: {_customers.Address}");
            Console.WriteLine($"Phone: {_customers.Phone}");
            Console.WriteLine($"Email: {_customers.Email}");
            Console.WriteLine($":Previous Orders {_customers.Orders.Count}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("[1] - Please Enter Name: ");
            Console.WriteLine("[2] - Please Enter Address:");
            Console.WriteLine("[3] - Please Enter Phone Number:");
            Console.WriteLine("[4] - Please Enter Email:");
            Console.WriteLine("[5] - Save Customer: ");
          //  Console.WriteLine("[6] - Show A List Of Your Orders: ");
            Console.WriteLine("[x] - Return to Customers Menu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Please Enter Customers Name:");
                    _customers.Name = Console.ReadLine();
                    return MenuType.AddCustomers;
                case "2":
                    Console.WriteLine("Please Enter Customers Address:");
                    _customers.Address = Console.ReadLine();
                    return MenuType.AddCustomers;
                case "3":
                    Console.WriteLine("Please Enter Customers Phone Number: ");
                    _customers.Phone = Console.ReadLine();
                    return MenuType.AddCustomers;
                case "4":
                    Console.WriteLine("Please Enter Customers Email:");
                    _customers.Email = Console.ReadLine();
                    return MenuType.AddCustomers;
                case "5":
                    try
                    {
                        _customersBL.AddCustomers(_customers);
                    }
                    catch (System.Exception exception)
                    {
                        Console.WriteLine($"{exception.Message}" +
                                           "Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddCustomers;
                    }
                    Console.WriteLine($"{SingletonCustomer.customers.Name} You Have Been Added To Our List Of Customers. \n   Please Press Enter To Continue.");
                    Console.ReadLine();
                    return MenuType.CustomersMenu;

                // case "6":
                //     Console.WriteLine("Get A List Of Customers Items:");
                //     _customers.Orders = new List<Orders>();
                //     return MenuType.ShowOrders;

                case "x":
                    return MenuType.CustomersMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowCustomers;
            }
        }
    }
}
