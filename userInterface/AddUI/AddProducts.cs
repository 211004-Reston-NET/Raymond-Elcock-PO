using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddProducts : IMenu
    {
        private static Products _products = new Products();
        private IProductsBL _productsBL;
         
        public AddProducts(IProductsBL p_productsBL)
        {
            _productsBL = p_productsBL;
        }

       

        public void Menu()
        {
            Console.WriteLine("Add a new Store");
            Console.WriteLine("Name - " + _products.Name);
            Console.WriteLine("Address - "+ _products.Name);
            
            Console.WriteLine("[5] - Add Store");
            Console.WriteLine("[4] - Input value for Store Name");
            Console.WriteLine("[3] - Input value for  Store Address");
            Console.WriteLine("[2] - Input value for Phone Number");
            Console.WriteLine("[1] - Input value for Email");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
                case "5":
                    //Add implementation to talk to the repository method to add a Store
                    _productsBL.AddProducts(_products);
                    return MenuType.ProductsMenu;
                    case "4":
                    Console.WriteLine("Type in the value for the StoreFront Name");
                    _products.Name = Console.ReadLine();
                    return MenuType.AddProducts;
                case "3":
                    Console.WriteLine("Type in the value for the Store Address");
                    _products.Name = Console.ReadLine();
                    return MenuType.AddProducts;
                
                case "0":
                    return MenuType.ProductsMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowProducts;
            }
        }
    }
}