using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowStore : ICustomersBL
    {
        private ICustomersBL _restBL;
        public ShowStore(ICustomersBL s_frontBL)
        {
            _restBL = s_frontBL;
        }


        public void Customers()
        {
            Console.WriteLine("List of Customers");
            List<Customers> listOfCustomers = _restBL.GetAllCustomers();

            foreach (Customers rest in listOfCustomers)
            {
                Console.WriteLine("====================");
                Console.WriteLine(rest);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public StoreType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return StoreType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return StoreType.ShowStore;
            }
        }
    }
}