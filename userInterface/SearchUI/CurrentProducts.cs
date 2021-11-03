using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentProducts : IMenu
    {
        private IProductsBL _productsBL;
        private static Products _currentProducts = new Products();
        public CurrentProducts(IProductsBL p_productsBL)
        {
            this._productsBL = p_productsBL;
        }

        public void Menu()
        {
            List<Products> listOfProducts = _productsBL.GetProducts(ShowProducts._findProductsName);

            Console.WriteLine("This is the search result");
            foreach (Products products in listOfProducts)
            {
                Console.WriteLine("====================");
                Console.WriteLine(products);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[x] - Go Back");
            Console.WriteLine("[1] - Search Name Of Products");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "x":
                    return MenuType.ProductsMenu;
                case "1":
                    Console.WriteLine("Products to Search For: ");
                    _currentProducts.ProductName = Console.ReadLine();
                   // _currentProducts = _currentProducts.GetProducts(_currentProducts.ProductName);
                    return MenuType.CurrentProducts;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentProducts;
            }
        }
    }
}