using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowStoreFronts : IMenu
    {
        private IStoreFrontsBL _storeFrontsBL;

        public ShowStoreFronts(IStoreFrontsBL p_storeFrontsBL)
        {
            _storeFrontsBL = p_storeFrontsBL;
        }
        public void Menu()
        {
            Console.WriteLine("-----List of StoreFronts-----");
            Console.WriteLine("--------------------------------");
            List<StoreFronts> listOfStoreFronts = _storeFrontsBL.GetAllStoreFronts();

            foreach (StoreFronts storeFronts in listOfStoreFronts)
            {
                Console.WriteLine("====================");
                Console.WriteLine($"ID: {storeFronts.StoreFrontId}");
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
                case "0":
                    return MenuType.StoreFrontsMenu;
                case "1":
                    Console.WriteLine("Enter a name for the StoreFront you want to find");
                    SingletonCustomer.storeFronts.StoreName = Console.ReadLine();
                    return MenuType.CurrentStoreFronts;
                case "2":
                    Console.WriteLine("Enter the ID of the StoreFront you want to find");

                    try
                    {
                        SingletonCustomer.storeFronts.StoreFrontId = Int32.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please put in a number!");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        return MenuType.ShowStoreFronts;
                    }

                    return MenuType.ShowLineItems;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStoreFronts;
            }
        }
    }
}