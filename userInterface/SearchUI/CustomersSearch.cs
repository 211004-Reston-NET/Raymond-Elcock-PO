using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentCustomers : IMenu
    {
        private ICustomersBL _customersBL;
        public CurrentCustomers(ICustomersBL p_customersBL)
        {
            this._customersBL = p_customersBL;
        }

        public void Menu()
        {
            List<Customers> listOfCustomers = _customersBL.GetCustomers(ShowCustomers._findCustomersName);

            Console.WriteLine("This is the search result");
            foreach (Customers customers in listOfCustomers)
            {
                Console.WriteLine("====================");
                Console.WriteLine(customers);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return MenuType.ShowCustomers;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}