using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddLineItems : IMenu
    {
        private static LineItems _lineItems = new LineItems();
        private ILineItemsBL _lineItemsBL;
         
        public AddLineItems(ILineItemsBL lineItems)
        {
            _lineItemsBL = lineItems;
        }

       

        public void Menu()
        {
            Console.WriteLine("Add a new Line Item");
            Console.WriteLine("Name - " + _lineItems.StoreItems);
            Console.WriteLine("Address - "+ _lineItems._StoreItemQuantity);
           
            Console.WriteLine("[1] - Add New Item");
            Console.WriteLine("[2] - Input  Store Line Items");
            Console.WriteLine("[3] - Input  Line Items Quantity");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
            case "4":
                    
                    try
                    {
                         _lineItemsBL.AddLineItems(_lineItems);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddLineItems;
                    }
                    
                    return MenuType.CustomersMenu;
                case "1":
                    Console.WriteLine("Type in Line Items");
                    _lineItems.StoreItems = Console.ReadLine();
                    return MenuType.AddLineItems;
                case "2":
                    Console.WriteLine("Type in Line Item Quantity");
                    _lineItems._StoreItemQuantity = Console.ReadLine();
                    return MenuType.AddLineItems;
                
                case "0":
                    return MenuType.LineItemsMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowLineItems;
            }
        }
    }
}
