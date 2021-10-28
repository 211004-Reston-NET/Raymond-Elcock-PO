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
            Console.WriteLine("----- Customers Menu Choices-----\n");
            Console.WriteLine("[1] - Add A New Customer: ");
            Console.WriteLine("[2] - View A List of Customers Orders For Store: ");
            Console.WriteLine("[3] - Search For A Customer: ");
            Console.WriteLine("[x] - Go back to The Main Menu");
            Console.WriteLine("------------------------------------\n");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                //This case will add a customer to store app
                case "1":
                    return MenuType.AddCustomers;
                //This case will show a list of customers    
                case "2":
                    return MenuType.ShowCustomers;
                //This case will search for a customer
                case "3":
                    return MenuType.CurrentCustomers;
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