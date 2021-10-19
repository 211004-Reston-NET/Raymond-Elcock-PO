using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowCustomers : IMenu
    {
        private ICustomersBL s_customersBL;
        public ShowCustomers(ICustomersBL _customersBL)
        {
            _customersBL = s_customersBL;
        }


        public void Menu()
        {
            Console.WriteLine("List of Customers");
            List<Customers> listOfCustomers = s_customersBL.GetAllCustomers();

            foreach (Customers customers in listOfCustomers)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Customer's Menu");
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