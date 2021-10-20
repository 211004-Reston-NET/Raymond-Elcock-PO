using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowLineItems : IMenu
    {
        private ILineItemsBL p_lineItemsBL;
        public ShowLineItems(ILineItemsBL _lineItemsBL)
        {
            _lineItemsBL = p_lineItemsBL;
        }


        public void Menu()
        {
            Console.WriteLine("List of Line Items");
            List<LineItems> listOfLineItems = p_lineItemsBL.GetAllLineItems();

            foreach (LineItems lineItems in listOfLineItems)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Line Items List");
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
                    return MenuType.ShowLineItems;
            }
        }
    }
}