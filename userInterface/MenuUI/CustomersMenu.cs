using System;

namespace userInterface
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class CustomersMenu : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {   
            Console.WriteLine("Welcome to the Customers Menu! ");
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("------ Customers Menu Choices------\n");
            Console.WriteLine("[1] - Add A New Customer: ");
            Console.WriteLine("[2] - Show A List of Customers For Store: ");
            Console.WriteLine("[3] - Buy a Product:");
            //Console.WriteLine("Welcome to the Restaurant Menu!");
            Console.WriteLine("[x] Go back to The Main Menu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.AddCustomers;
                case "2":
                    return MenuType.ShowCustomers;
                //If i want to add more cases later
                case "3":
                    return MenuType.ProductsMenu;
                //case "4":
                  //  return MenuType.ProductsMenu;      
                case "x":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ExitMenu;
            }
        }
    }

}