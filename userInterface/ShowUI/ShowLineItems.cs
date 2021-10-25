using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowLineItems : IMenu
    {
        private ILineItemsBL p_lineItemsBL;
        public static string _findLineItemsName;
        public ShowLineItems(ILineItemsBL _lineItemsBL)
        {
            _lineItemsBL = p_lineItemsBL;
        }


        public void Menu()
        {
            Console.WriteLine("______List of Line Items______");
            List<LineItems> listOfLineItems = p_lineItemsBL.GetAllLineItems();

            foreach (LineItems lineItems in listOfLineItems)
            {
                Console.WriteLine("====================");
                Console.WriteLine(lineItems);
                //Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Search for a Line Item");
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