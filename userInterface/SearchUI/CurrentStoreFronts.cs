using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentStoreFronts : IMenu
    {
        private IStoreFrontsBL _storeFrontsBL;
        private static StoreFronts _currentStoreFronts = new StoreFronts();
        public CurrentStoreFronts(IStoreFrontsBL p_storeFrontsBL)
        {
            this._storeFrontsBL = p_storeFrontsBL;
        }

        public void Menu()
        {
            Console.WriteLine("This is the search result");
            Console.WriteLine("====================");
            Console.WriteLine(_currentStoreFronts);
            // need to add if no storefront is not found
            Console.WriteLine("====================");
            Console.WriteLine("[x] - Go Back: ");
            Console.WriteLine("[1] - Search Name Of StoreFronts: ");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "x":
                    return MenuType.StoreFrontsMenu;
                case "1":
                    Console.WriteLine("StoreFront to Search For: ");
                    _currentStoreFronts.StoreName = Console.ReadLine();
                    _currentStoreFronts = _storeFrontsBL.GetStoreFronts(_currentStoreFronts.StoreName);
                    return MenuType.CurrentStoreFronts;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentStoreFronts;
            }
        }
    }
}