using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddProducts : IProductsBL
    {
        private static Products _rest = new Products();
        private IProductsBL _restBL;
         
        public AddProducts(IProductsBL p_restBL)
        {
            _restBL = p_restBL;
        }

       

        public void Store()
        {
            Console.WriteLine("Add a new Store");
            Console.WriteLine("Name - " + _rest.StoreName);
            Console.WriteLine("Address - "+ _rest.StoreAddress);
            Console.WriteLine("Phone Number - "+ _rest.PhoneNumber);
            Console.WriteLine("Email - "+ _rest.Email);
            Console.WriteLine("[5] - Add Store");
            Console.WriteLine("[4] - Input value for Store Name");
            Console.WriteLine("[3] - Input value for  Store Address");
            Console.WriteLine("[2] - Input value for Phone Number");
            Console.WriteLine("[1] - Input value for Email");
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