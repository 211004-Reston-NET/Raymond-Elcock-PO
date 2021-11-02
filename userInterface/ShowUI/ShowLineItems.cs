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
            List<LineItems> listOfLineItems = _lineItemsBL.GetLineItemsByStoreID(SingletonCustomer.storeFronts.StoreFrontId);

            foreach (LineItems product in listOfLineItems)
            {
                Console.WriteLine("====================");
                Console.WriteLine(product);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Search for a Line Item");
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "x":
                case "1":
                    Console.WriteLine("Enter a name for the Customer you want to find");
                    _findLineItemsName = Console.ReadLine();
                    return MenuType.CurrentLineItems;

                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowLineItems;
            }
        }
    }
}