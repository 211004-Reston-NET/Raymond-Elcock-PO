using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
     public class ShowStoreFronts : IMenu
    {
        private IStoreFrontsBL _storeFrontsBL;
        public static string _findStoreFrontsName;
        public ShowStoreFronts(IStoreFrontsBL p_storeFrontsBL)
        {
            _storeFrontsBL = p_storeFrontsBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of StoreFronts");
            List<StoreFronts> listOfStoreFronts = _storeFrontsBL.GetAllStoreFronts();

            foreach (StoreFronts storeFronts in listOfStoreFronts)
            {
                Console.WriteLine("====================");
                Console.WriteLine(storeFronts);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Search for a StoreFront");
            Console.WriteLine("[2] - Choose Which Store you would like to buy from");
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "x":
                    return MenuType.StoreFrontsMenu;
                case "1":
                    Console.WriteLine("Enter a name for the StoreFront you want to find");
                    _findStoreFrontsName = Console.ReadLine();
                    return MenuType.CurrentStoreFronts;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStoreFronts;
            }
        }
    }
}