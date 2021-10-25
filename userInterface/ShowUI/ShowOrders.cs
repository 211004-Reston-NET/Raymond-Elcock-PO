using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowOrders : IMenu
    {
        private IOrdersBL _ordersBL;
        public static string _findOrdersName;
        public ShowOrders(IOrdersBL p_ordersBL)
        {
            _ordersBL = p_ordersBL;
        }
        public void Menu()
        {
            Console.WriteLine("______List of Orders______");

            List<Orders> listOfOrders = _ordersBL.GetAllOrders();

            foreach (Orders orders in listOfOrders)
            {
                Console.WriteLine("====================");
                Console.WriteLine(orders);
                //Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Search for a Order");
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.OrdersMenu;
               // case "1":
                 //   Console.WriteLine("Enter a name for the Restaurant you want to find");
                   // _findOrdersName = Console.ReadLine();
                   // return MenuType.CurrentRestaurant;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}