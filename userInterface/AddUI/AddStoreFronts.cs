using System;
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
                Console.WriteLine("---------------------------\n");
                Console.WriteLine("Add a new Store");
                Console.WriteLine("Name - " + _storeFronts.StoreName);
                Console.WriteLine("Address - "+ _storeFronts.StoreName);
                Console.WriteLine($"List Of Orders: {_storeFronts.Orders}");
                Console.WriteLine($"List Of Productss: {_storeFronts.Products}");
                Console.WriteLine("[1] - Enter A Store Name");
                Console.WriteLine("[2] - Enter A Store Address");
                Console.WriteLine("[3] - View A List Of Orders");
                Console.WriteLine("[4] - View A LIst Of Products");
                Console.WriteLine("[5] - Save A StoreFront");
                Console.WriteLine("[x] - Go Back");
            }

            public MenuType YourChoice()
            {
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    
                    case "1":
                        Console.WriteLine("Please Enter Stores Name:");
                        _storeFronts.StoreName = Console.ReadLine();
                        return MenuType.AddStoreFronts;
                    case "2":
                        Console.WriteLine("Please Enter Stores Address:");
                        _storeFronts.StoreAddress = Console.ReadLine();
                        return MenuType.AddStoreFronts;
                    case "3":
                        Console.WriteLine("View A List Of Orders: ");
                        _storeFronts.Orders = Console.ReadLine();
                        return MenuType.ShowOrders;
                    case "4":
                        Console.WriteLine("View A List of Products:");
                        _storeFronts.Products = Console.ReadLine();
                        return MenuType.ShowProducts;
                    case "5":
                        _storeFrontsBL.AddStoreFronts(_storeFronts);
                        Console.WriteLine("StoreFront Has Been Added");
                        Console.WriteLine("Please Press Enter! ");
                        Console.ReadLine();
                        return MenuType.StoreFrontsMenu;
                    
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