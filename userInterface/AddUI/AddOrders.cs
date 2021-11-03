using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddOrders : IMenu
    {
        private static Orders _orders = new Orders();
        private IOrdersBL _ordersBL;

        public AddOrders(IOrdersBL orders)
        {
            _ordersBL = orders;
        }
        public void Menu()
        {
            Console.WriteLine("Welcome To Add A Customer! ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Store Address: {_orders.StoreAddress}");
            Console.WriteLine($"Total Price : {_orders.TotalPrice}");
            
            Console.WriteLine($":Previous Orders {_orders.Order.Count}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("[1] - Please Enter Store Address: ");
            Console.WriteLine("[2] - Please Enter Total Price:");
            Console.WriteLine("[3] - Place An Order:");
            Console.WriteLine("[4] - Save Order: ");
            Console.WriteLine("[5] - Show A List Of Your Orders: ");
            Console.WriteLine("[x] - Return to Order Menu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Please Enter Customers Name:");
                    _orders.StoreAddress= Console.ReadLine();
                    return MenuType.AddOrders;
                case "2":
                    Console.WriteLine("Please Enter Total Price:");
                   _orders.TotalPrice = Int32.Parse(Console.ReadLine());
                    return MenuType.AddOrders;
                case "3":
                    Console.WriteLine("Place A Order:  ");
                   _orders.Order = new List<Orders>();
                    return MenuType.PlaceOrder;
                
                case "4":
                    try
                    {
                        _ordersBL.AddOrders(_orders);
                    }
                    catch (System.Exception exception)
                    {
                        Console.WriteLine($"{exception.Message}" +
                                           "Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddOrders;
                    }
                    Console.WriteLine($"{SingletonOrder.orders.StoreAddress} You Have Been Added To Our List Of Customers. \n   Please Press Enter To Continue.");
                    Console.ReadLine();
                    return MenuType.OrdersMenu;

                case "5":
                    Console.WriteLine("Get A List Of Orders Items:");
                    _orders.Order = new List<Orders>();
                    return MenuType.ShowOrders;

                case "x":
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