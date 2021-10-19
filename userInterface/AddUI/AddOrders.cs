using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddOrders : IMenu
    {
        private static Orders _orders = new Orders();
        private IOrdersBL _ordersBL;
         
        public AddOrders(IOrdersBL p_orders)
        {
            _ordersBL = p_orders;
        }

       

        public void Menu()
        {
            Console.WriteLine("Add a new Order");
            Console.WriteLine("Address - "+ _orders.StoresAddress);
            Console.WriteLine("");
            Console.WriteLine("[5] - Add Order");
           
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
                case "5":
                    //Add implementation to talk to the repository method to add a Store
                    _ordersBL.AddOrders(_orders);
                    return MenuType.OrdersMenu;
                    case "4":
                    Console.WriteLine("Type in the value for the Stores Address");
                    _orders.StoresAddress = Console.ReadLine();
                    return MenuType.AddOrders;
                
                case "2":
                    Console.WriteLine("Type in the value for the  Store Phone Number");
                    _orders.StoreAddress = Console.ReadLine();
                    return MenuType.AddOrders;
                
                case "0":
                    return MenuType.OrdersMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowOrders;
            }
        }
    }
}