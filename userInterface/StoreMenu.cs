using System;

namespace userInterface
{
    public class StoreMenu : IStore
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Store Menu!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[3] - List of Restaurant");
            Console.WriteLine("[2] - Checkout");
            Console.WriteLine("[1] - Buy a Product");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public void Store()
        {
            throw new NotImplementedException();
        }

        public StoreType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "3":
                    return StoreType.ShowStore;
                case "2":
                    return StoreType.StoreMenu;
                case "1":
                    return StoreType.StoreMenu;
                case "0":
                    return StoreType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return StoreType.StoreMenu;
            }
        }
    }
}