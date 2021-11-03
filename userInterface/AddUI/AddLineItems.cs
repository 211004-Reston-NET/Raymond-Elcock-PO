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
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Product Name: {_lineItems.Product.ProductName}");
            Console.WriteLine($"Product Quantity: {_lineItems.StoreQuantity}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("[1] - Please Enter A  Product Name: ");
            Console.WriteLine("[2] - Please Enter A Product Quantity: ");
            Console.WriteLine("[3] - Save Line Item: ");
            Console.WriteLine("[x] - Return to Line Items Menu: ");
            Console.WriteLine("------------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {

                case "1":
                    Console.WriteLine("Please Enter Product Name:");
                    _lineItems.Product.ProductName = Console.ReadLine();
                    return MenuType.AddLineItems;
                case "2":
                    Console.WriteLine("Please Enter Product Quantity:");
                    _lineItems.StoreQuantity = Int32.Parse(Console.ReadLine());
                    return MenuType.AddLineItems;
                
               // case "6":
                 //    _lineItemsBL.AddLineItems(_lineItems);
                   // Console.WriteLine("Line Item Has Been Added");
                    //Console.WriteLine("Please Press Enter! ");
                   // Console.ReadLine();
                    //return MenuType.LineItemsMenu;

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
