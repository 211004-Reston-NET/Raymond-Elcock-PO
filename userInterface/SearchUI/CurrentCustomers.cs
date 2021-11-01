using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentCustomers : IMenu
    {
        private ICustomersBL _customersBL;
        private static Customers _currentCustomer = new Customers();
        public CurrentCustomers(ICustomersBL p_customersBL)
        {
            this._customersBL = p_customersBL;
        }

        public void Menu()
        {
            Console.WriteLine("This is the search result");
            Console.WriteLine("====================");
            Console.WriteLine(_currentCustomer);
            // need to add if no customer is found
            Console.WriteLine("====================");
            Console.WriteLine("[x] - Go Back: ");
            Console.WriteLine("[1] - Search Name Of Customer: ");
            
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "x":
                    return MenuType.CustomersMenu;
                case "1":
                    Console.WriteLine("Customer to Search For: ");
                    _currentCustomer.Name = Console.ReadLine();
                    _currentCustomer = _customersBL.GetCustomers(_currentCustomer.Name); 
                    return MenuType.CurrentCustomers;
                
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentCustomers;
            }
        }
    }
}