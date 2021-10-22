using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowCustomers : IMenu
    {
        private ICustomersBL _customersBL;
        public ShowCustomers(ICustomersBL p_customersBL)
        {
            _customersBL = p_customersBL;
        }


        public void Menu()
        {
            Console.WriteLine("______List of Customers______");
            List<Customers> listOfCustomers = _customersBL.GetAllCustomers();

            foreach (Customers customers in listOfCustomers)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Customer's Information");
                Console.WriteLine(customers);
                
            }
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
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