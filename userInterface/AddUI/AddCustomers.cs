using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddCustomers : ICustomersBL
    {
        private static Customers _rest = new Customers();
        private ICustomersBL _restBL;
         
        public AddCustomers(ICustomersBL p_restBL)
        {
            _restBL = p_restBL;
        }

       

        public void Store()
        {
            Console.WriteLine("Add a new Store");
            Console.WriteLine("Name - " + _rest.Name);
            Console.WriteLine("Address - "+ _rest.Address);
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
                
            case "4":
                    //Anything inside the try block will be catched if an exception has risen
                    //Laymen's term if a problem has happened while doing this code, it will instead do the catch block
                    try
                    {
                         _restBL.AddRestaurant(_rest);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddRestaurant;
                    }
                    
                    return MenuType.RestaurantMenu;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _rest.Name = Console.ReadLine();
                    return MenuType.AddRestaurant;
                case "2":
                    Console.WriteLine("Type in the value for the State");
                    _rest.State = Console.ReadLine();
                    return MenuType.AddRestaurant;
                case "1":
                    Console.WriteLine("Type in the value for the City");
                    _rest.City = Console.ReadLine();
                    return MenuType.AddRestaurant;
                case "0":
                    return MenuType.RestaurantMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowRestaurant;
            }
        }
    }
}
