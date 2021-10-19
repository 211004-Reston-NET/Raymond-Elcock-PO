using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowOrders : IMenu
    {
        private IOrdersBL s_ordersBL;
        public ShowOrders(IOrdersBL _ordersBL)
        {
            _ordersBL = s_ordersBL;
        }


        public void Menu()
        {
            Console.WriteLine("List of Orders");
            List<Orders> listOfOrders = s_ordersBL.GetAllOrders();

            foreach (Orders orders in listOfOrders)
            {
                Console.WriteLine("====================");
                Console.WriteLine(orders);
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
                    return MenuType.ProductsMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowOrders;
            }
        }
    }
}