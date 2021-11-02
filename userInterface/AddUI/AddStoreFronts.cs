using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddStoreFronts : IMenu
    {
        private static StoreFronts _storeFronts = new StoreFronts();
        private IStoreFrontsBL _storeFrontsBL;

        public AddStoreFronts(IStoreFrontsBL p_storeFrontsBL)
        {
            _storeFrontsBL = p_storeFrontsBL;
        }



        public void Menu()
        {
            Console.WriteLine("Welcome To Add A StoreFront! ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Name: {_storeFronts.StoreName}");
            Console.WriteLine($"Address: {_storeFronts.StoreAddress}");
            Console.WriteLine($"Phone: {_storeFronts.StorePhone}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("[1] - Please Enter Name: ");
            Console.WriteLine("[2] - Please Enter Address: ");
            Console.WriteLine("[3] - Please Enter Phone Number: ");
            Console.WriteLine("[4] - Save A StoreFront: ");
            Console.WriteLine("[x] - Go Back: ");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {

                case "1":
                    Console.WriteLine("Please Enter Stores Name: ");
                    _storeFronts.StoreName = Console.ReadLine();
                    return MenuType.AddStoreFronts;
                case "2":
                    Console.WriteLine("Please Enter Stores Address: ");
                    _storeFronts.StoreAddress = Console.ReadLine();
                    return MenuType.AddStoreFronts;
                case "3":
                    Console.WriteLine("Please Enter Stores Phone Number: ");
                    _storeFronts.StorePhone = Console.ReadLine();
                    return MenuType.AddStoreFronts;
                case "4":
                    _storeFrontsBL.AddStoreFronts(_storeFronts);
                    Console.WriteLine("StoreFront Has Been Added");
                    Console.WriteLine("Please Press Enter! ");
                    Console.ReadLine();
                    return MenuType.StoreFrontsMenu;

                case "x":
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