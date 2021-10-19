using System;
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
            Console.WriteLine("Add a new Customer");
            Console.WriteLine("Name - " + _customers.Name);
            Console.WriteLine("Address - "+ _customers.Address);
            Console.WriteLine("Phone Number - "+ _customers.PhoneNumber);
            Console.WriteLine("Email - "+ _customers.Email);
            Console.WriteLine("[1] - Add Store");
            Console.WriteLine("[2] - Input  Customers Name");
            Console.WriteLine("[3] - Input  Customers Address");
            Console.WriteLine("[4] - Input  Customers Phone Number");
            Console.WriteLine("[5] - Input  Customers Email");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
            case "1":
                    
                    try
                    {
                         _customersBL.AddCustomers(_customers);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddCustomers;
                    }
                    
                    return MenuType.CustomersMenu;
                case "2":
                    Console.WriteLine("Please Enter Customers Name:");
                    _customers.Name = Console.ReadLine();
                    return MenuType.AddCustomers;
                case "3":
                    Console.WriteLine("Please Enter Customers Address:");
                    _customers.Address = Console.ReadLine();
                    return MenuType.AddCustomers;
                case "4":
                    Console.WriteLine("Please Enter Customers Phone Number:");
                    _customers.Email = Console.ReadLine();
                    return MenuType.AddCustomers;
                case "5":
                    Console.WriteLine("Please Enter Customers Email: ");
                    _customers.Email = Console.ReadLine();
                    return MenuType.AddCustomers;
                case "0":
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
