using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowProducts : IMenu
    {
        private IProductsBL p_productsBL;
        public ShowProducts(IProductsBL _productsBL)
        {
            _productsBL = p_productsBL;
        }


        public void Menu()
        {
            Console.WriteLine("List of Products");
            List<Products> listOfProducts = p_productsBL.GetAllProducts();

            foreach (Products products in listOfProducts)
            {
                Console.WriteLine("====================");
                Console.WriteLine(products);
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