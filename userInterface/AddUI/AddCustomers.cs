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
            Console.WriteLine("---------------------------\n");
            Console.WriteLine($"Name: {_customers.Name}");
            Console.WriteLine($"Address: {_customers.Address}");
            Console.WriteLine($"Phone: {_customers.Phone}");
            Console.WriteLine($"Email: {_customers.Email}");
            //Console.WriteLine($"List Of Orders: {_customers.Orders}");
            // If i need to add another input console
            //Console.WriteLine("[] Input Customer ID");
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("[1] - Please Enter A  Name: ");
            Console.WriteLine("[2] - Please Enter A Address:");
            Console.WriteLine("[3] - Please Enter A Phone Number:");
            Console.WriteLine("[4] - Please Enter A Email:");
            Console.WriteLine("[5] - Show A List of Order Items");
            Console.WriteLine("[6] - Save Customer");
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
                    Console.WriteLine("Get A List Of Customers Items:");
                    _customers.Orders = new List<Orders>();
                    return MenuType.ShowOrders;
                //case "6":
                   // Console.WriteLine("Search For A Customer:");
                     //_customers.CurrentCustomers = Console.ReadLine();
                     //return MenuType.CurrentCustomers;

                case "6":
                     _customersBL.AddCustomers(_customers);
                     Console.WriteLine("Customer Has Been Added");
                     Console.WriteLine("Please Press Enter! ");
                     Console.ReadLine();
                    return MenuType.CustomersMenu;
                   
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
