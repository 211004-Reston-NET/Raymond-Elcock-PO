using System;

namespace userInterface
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class StoreFrontsMenu : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {
            Console.WriteLine("    Welcome to the StoreFronts Menu!  ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-------- StoreFronts Menu Choices--------");
            Console.WriteLine("[1] - Add New StoreFronts: ");
            Console.WriteLine("[2] - View A List of StoreFronts: ");
            Console.WriteLine("[3] - Search For A StoreFront: ");
            Console.WriteLine("[x] - Go back to The Main Menu: ");
            Console.WriteLine("---------------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.AddStoreFronts;
                case "2":
                    return MenuType.ShowStoreFronts;
                case "3":
                    return MenuType.CurrentStoreFronts;   
                case "x":
                    return MenuType.MainMenu; 
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreFrontsMenu;
            }
        }
    }
}