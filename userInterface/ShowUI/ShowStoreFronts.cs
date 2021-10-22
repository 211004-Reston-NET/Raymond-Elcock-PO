using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowStoreFronts : IMenu
    {
        private IStoreFrontsBL p_storeFrontsBL;
        public ShowStoreFronts(IStoreFrontsBL _storeFrontsBL)
        {
            _storeFrontsBL = p_storeFrontsBL;
        }


        public void Menu()
        {
            Console.WriteLine("List of Products");
            List<StoreFronts> listOfStoreFronts = p_storeFrontsBL.GetAllStoreFronts();

            foreach (StoreFronts storeFronts in listOfStoreFronts)
            {
                Console.WriteLine("====================");
                Console.WriteLine("StoreFronts");
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
                    return MenuType.StoreFrontsMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStoreFronts;
            }
        }
    }
}