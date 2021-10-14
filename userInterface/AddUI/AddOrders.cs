using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddOrders : IOrders
    {
        private static Orders _rest = new Orders();
        private IOrdersBL _restBL;
         
        public AddOrders(IOrdersBL p_restBL)
        {
            _restBL = p_restBL;
        }

       

        public void Store()
        {
            Console.WriteLine("Add a new Order");
            Console.WriteLine("Address - "+ _rest.StoresAddress);
            Console.WriteLine("");
            Console.WriteLine("[5] - Add Order");
           
            Console.WriteLine("[0] - Go Back");
        }

        public StoreType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
                case "5":
                    //Add implementation to talk to the repository method to add a Store
                    _restBL.AddStore(_rest);
                    return StoreType.StoreMenu;
                    case "4":
                    Console.WriteLine("Type in the value for the StoreFront Name");
                    _rest.StoreName = Console.ReadLine();
                    return StoreType.AddStore;
                case "3":
                    Console.WriteLine("Type in the value for the Store Address");
                    _rest.StoreName = Console.ReadLine();
                    return StoreType.AddStore;
                case "2":
                    Console.WriteLine("Type in the value for the  Store Phone Number");
                    _rest.StoreAddress = Console.ReadLine();
                    return StoreType.AddStore;
                case "1":
                    Console.WriteLine("Type in the value for the Store Email");
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