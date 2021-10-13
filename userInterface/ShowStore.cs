using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowStore : IStore
    {
        private IStoreBL _restBL;
        public ShowStore(IStoreBL s_frontBL)
        {
            _restBL = s_frontBL;
        }


        public void Store()
        {
            Console.WriteLine("List of Stores");
            List<StoreFront> listOfStores = _restBL.GetAllStores();

            foreach (StoreFront rest in listOfStores)
            {
                Console.WriteLine("====================");
                Console.WriteLine(rest);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public StoreType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
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