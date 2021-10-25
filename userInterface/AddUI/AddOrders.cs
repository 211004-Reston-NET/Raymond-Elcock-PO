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
                Console.WriteLine("Welcome To Add A Order! ");
                Console.WriteLine("---------------------------\n");
                Console.WriteLine($"Name: {_orders.StoreAddress}");
                Console.WriteLine($"Address: {_orders.TotalPrice}");
                Console.WriteLine($"List Of Orders: {_orders.LineItems}");
                // If i need to add another input console
                //Console.WriteLine("[] Input Customer ID");
                Console.WriteLine("------------------------------------\n");
                Console.WriteLine("[1] - Please Enter A  Store Address: ");
                Console.WriteLine("[2] - Please Enter A Total Price:");
                Console.WriteLine("[3] - Please Enter An Item To Add:");
                //Console.WriteLine("[4] = Please Enter A Email:");
            // Console.WriteLine("[5] - Enter Your Order");
                Console.WriteLine("[4] - Save Order");
                Console.WriteLine("[x] - Return to Orders Menu");
            }

            public MenuType YourChoice()
            {
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    
                    case "1":
                        Console.WriteLine("Enter A Store Address: ");
                        _orders.StoreAddress = Console.ReadLine();
                        return MenuType.AddOrders;
                    
                    case "2":
                        Console.WriteLine("Enter A Total Price: ");
                        _orders.TotalPrice = Int32.Parse( Console.ReadLine());
                        return MenuType.AddOrders;
                    case "3":
                        Console.WriteLine("Enter A Order To Add: ");
                        _orders.LineItems = (Console.ReadLine());
                        return MenuType.ShowOrders;
                    case "4":
                        _ordersBL.AddOrders(_orders);
                        Console.WriteLine("Order Has Been Added");
                        Console.WriteLine("Please Press Enter! ");
                        Console.ReadLine();
                        return MenuType.OrdersMenu;
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