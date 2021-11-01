using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
     public class ShowLineItems : IMenu
    {
        private ILineItemsBL _lineItemsBL;
        public static string _findLineItemsName;
        public ShowLineItems(ILineItemsBL p_lineItemsBL)
        {
            _lineItemsBL = p_lineItemsBL;
        }
        public void Menu()
        {
            Console.WriteLine($"-----List of Line Items----- from {SingletonCustomer.location}");
            Console.WriteLine("------------------------------");
            List<LineItems> listOfLineItems = _lineItemsBL.GetLineItems(SingletonCustomer.orders.StoreFrontId);

            foreach (LineItems product in listOfLineItems)
            {
                Console.WriteLine("====================");
                Console.WriteLine(product);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Place Your Order Here");
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "x":
                    return MenuType.ShowStoreFronts;
                case "1":
                    
                    return MenuType.AddOrders;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}