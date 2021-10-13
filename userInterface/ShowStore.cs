using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowStore : IStore
    {
        private StoreBL _restBL;
        public ShowStore(StoreBL s_frontBL)
        {
            _storeBL = s_frontBL;
        }

        public global::System.Object Console { get; private set; }

        public void Store()
        {
            Console.WriteLine("List of Restaurant");
            List<Restaurant> listOfRestaurants = _restBL.GetAllRestaurant();

            foreach (Restaurant rest in listOfRestaurants)
            {
                Console.WriteLine("====================");
                Console.WriteLine(rest);
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
                    return StoreType.RestaurantMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowRestaurant;
            }
        }
    }
}