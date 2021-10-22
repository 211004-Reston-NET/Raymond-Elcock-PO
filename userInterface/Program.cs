using System;
using BusinessLogic;
using DataAccessLogic;

namespace userInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a boolean that has either a false or true value
            //I will use this to stop the while loop
            bool repeat = true;


            //This is example of polymorphism, abstraction, and inheritance all at the same time
            IMenu page = new MainMenu();
            

            //This is a while loop that will keep repeating until I changed the
            //repeat variable to false
            while (repeat)
            {
                //Clean the screen on the terminal
                Console.Clear();

                //IMenu interface can hold a bunch of objects as long as they inherited from
                //IMenu, this lets us dynamically change the page by having the page variable
                //Point to a different object each time
                page.Menu();
                MenuType currentPage = page.YourChoice();

                //switch case will change the page variable to point to another object to change
                //its MainMenu 
                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        //If user choosed to go back to the MainMenu
                        //page will start pointing to a MainMenu object instead
                        page = new MainMenu();
                        break;
                    
                    
                    case MenuType.CustomersMenu:
                        page = new CustomersMenu();
                        break;
                    case MenuType.ShowCustomers:
                        page = new ShowCustomers(new CustomersBL(new CustomersRepo()));
                        break;
                    case MenuType.AddCustomers:
                        page = new AddCustomers(new CustomersBL(new CustomersRepo()));
                        break;
                     case MenuType.LineItemsMenu:
                        page = new LineItemsMenu();
                        break;
                    case MenuType.ShowLineItems:
                        page = new ShowLineItems(new LineItemsBL(new LineItemsRepo()));
                        break;
                    case MenuType.AddLineItems:
                        page = new AddLineItems(new LineItemsBL(new LineItemsRepo()));
                        break;
                    case MenuType.OrdersMenu:
                        page = new CustomersMenu();
                        break;
                    case MenuType.ShowOrders:
                        page = new ShowOrders(new OrdersBL(new OrdersRepo()));
                        break;
                    case MenuType.AddOrders:
                        page = new AddOrders(new OrdersBL(new OrdersRepo()));
                        break;
                    case MenuType.ProductsMenu:
                        page = new CustomersMenu();
                        break;
                    case MenuType.ShowProducts:
                        page = new ShowProducts(new ProductsBL(new ProductsRepo()));
                        break;
                    case MenuType.AddProducts:
                        page = new AddProducts(new ProductsBL(new ProductsRepo()));
                        break;
                     case MenuType.StoreFrontsMenu:
                        page = new CustomersMenu();
                        break;
                    case MenuType.ShowStoreFronts:
                        page = new ShowStoreFronts(new StoreFrontsBL(new StoreFrontsRepo()));
                        break;
                    case MenuType.AddStoreFronts:
                        page = new AddStoreFronts(new StoreFrontsBL(new StoreFrontsRepo()));
                        break;               

                    //This is a Exit to leave store
                    case MenuType.ExitMenu:
                        Console.WriteLine("You are exiting the application!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("You forgot to add a menu or Page!! ");
                        repeat = false;
                        break;
                }
            }

        }
    }
}