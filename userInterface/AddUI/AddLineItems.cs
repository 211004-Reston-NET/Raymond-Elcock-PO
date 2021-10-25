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
             Console.WriteLine("Welcome To Add A Line Items! ");
              Console.WriteLine("---------------------------\n");
            Console.WriteLine($"Name: {_lineItems.StoreItems}");
            Console.WriteLine($"Address: {_lineItems.StoreQuantity}");
            //Console.WriteLine($"Orders: {_customers.Orders}");
            // If i need to add another input console
            //Console.WriteLine("[] Input Customer ID");
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("[1] - Please Enter A  Store Item Name: ");
            Console.WriteLine("[2] - Please Enter A Quantity For Item:");
           // Console.WriteLine("[5] - Enter Your Order");
            Console.WriteLine("[3] - Save Line Items");
            Console.WriteLine("[x] - Return to Line Items Menu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
            case "1":
                    Console.WriteLine("Please Enter Items Name:");
                    _lineItems.StoreItems = Console.ReadLine();
                    return MenuType.AddOrders;
                case "2":
                    Console.WriteLine("Please Enter Items Quantity:");
                    _lineItems.StoreQuantity = Int32.Parse( Console.ReadLine());
                    return MenuType.AddOrders;
                case "3":
                    _lineItemsBL.AddLineItems(_lineItems);
                     Console.WriteLine("Line Item Has Been Added");
                     Console.WriteLine("Please Press Enter! ");
                     Console.ReadLine();
                    return MenuType.LineItemsMenu;  
                
                case "x":
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
