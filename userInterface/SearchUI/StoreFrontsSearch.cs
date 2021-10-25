using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentStoreFronts : IMenu
    {
        private IStoreFrontsBL _storeFrontsBL;
        public CurrentStoreFronts(IStoreFrontsBL p_storeFrontsBL)
        {
            this._storeFrontsBL = p_storeFrontsBL;
        }

        public void Menu()
        {
            List<StoreFronts> listOfStoreFronts = _storeFrontsBL.GetStoreFronts(ShowStoreFronts._findStoreFrontsName);

            Console.WriteLine("This is the search result");
            foreach (StoreFronts storeFronts in listOfStoreFronts)
            {
                Console.WriteLine("====================");
                Console.WriteLine(storeFronts);
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
                    return MenuType.ShowStoreFronts;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}