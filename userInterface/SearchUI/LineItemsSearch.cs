using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentLineItems : IMenu
    {
        private ILineItemsBL _lineItemsBL;
        public CurrentLineItems(ILineItemsBL p_lineItemsBL)
        {
            this._lineItemsBL = p_lineItemsBL;
        }

        public void Menu()
        {
            List<LineItems> listOfLineItems = _lineItemsBL.GetLineItems(ShowLineItems._findLineItemsName);

            Console.WriteLine("This is the search result");
            foreach (LineItems lineItems in listOfLineItems)
            {
                Console.WriteLine("====================");
                Console.WriteLine(lineItems);
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
                    return MenuType.ShowLineItems;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentLineItems;
            }
        }
    }
}