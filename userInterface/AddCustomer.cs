using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddStores : IStore
    {
        private static StoreFront _rest = new StoreFront();
        private IStoreBL _restBL;
         
        public AddStores(IStoreBL p_restBL)
        {
            _restBL = p_restBL;
        }

       

        public void Store()
        {
            Console.WriteLine("Adding a new Store");
            Console.WriteLine("Name - " + _rest.StoreName);
            Console.WriteLine("State - "+ _rest.StoreAddress);
            Console.WriteLine("City - "+ _rest.PhoneNumber);
            Console.WriteLine("[4] - Add Store");
            Console.WriteLine("[3] - Input value for Name");
            Console.WriteLine("[2] - Input value for State");
            Console.WriteLine("[1] - Input value for City");
            Console.WriteLine("[0] - Go Back");
        }

        public StoreType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "4":
                    //Add implementation to talk to the repository method to add a restaurant
                    _restBL.AddStore(_rest);
                    return StoreType.StoreMenu;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _rest.StoreName = Console.ReadLine();
                    return StoreType.AddStore;
                case "2":
                    Console.WriteLine("Type in the value for the State");
                    _rest.StoreAddress = Console.ReadLine();
                    return StoreType.AddStore;
                case "1":
                    Console.WriteLine("Type in the value for the City");
                    _rest.PhoneNumber = Console.ReadLine();
                    return StoreType.AddStore;
                case "0":
                    return StoreType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return StoreType.ShowStore;
            }
        }
    }
}