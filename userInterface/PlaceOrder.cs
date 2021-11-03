using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class PlaceOrder : IMenu
    {


        private ILineItemsBL _lineItems;
        private ICustomersBL _customersBL;
        public PlaceOrder(ICustomersBL p_customersBL, ILineItemsBL p_lineItems)
        {
            _customersBL = p_customersBL;
            _lineItems = p_lineItems;
        }
        public void Menu()
        {
        
                List<LineItems> listOfLineItems = _lineItems.GetLineItems(SingletonCustomer.orders.StoreFrontId);
            
            
            Console.WriteLine($"Current List of Products from {SingletonCustomer.location}");
            
            foreach (LineItems product in listOfLineItems)
            {
                Console.WriteLine("\n-------------------------" +
                                
                                $" Name: {product.Product.ProductName}" +
                                $" Price: {product.Product.ProductPrice}" +
                                $" Stock Left: {product.StoreQuantity}");
            }
            Console.WriteLine("\n_________________________" +
                            "      Shopping Cart" +
                            "\n-------------------------");
            if (SingletonCustomer.orders.LineItems.Count == 0)
            {
                Console.WriteLine("          empty" +
                                "\n-------------------------");
            }
            foreach (LineItems item in SingletonCustomer.orders.LineItems)
            {
                Console.WriteLine($"  {item.Product.ProductName} " +
                                $"\n    StoreQuantity: {item.StoreQuantity} " +
                                $"\n    Product Price: {item.Product.ProductPrice}" +
                                "-------------------------");
            }
            Console.WriteLine($"Store Location: {SingletonCustomer.location}" +
                            $"\nTotal Price: {SingletonCustomer.orders.TotalPrice}" +
                            "-------------------------" +
                            "\n   [1] - Add Product to Shopping Cart" +
                            "\n   [2] - Complete Order" +
                            "\n   [x] - Main Menu");
        }

        public MenuType YourChoice()
        {
             List<LineItems> listOfLineItems = _lineItems.GetLineItems(SingletonCustomer.orders.StoreFrontId);
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("   Please Enter The Order You Would LIke To Add: ");
                    string _inputNames = Console.ReadLine().Trim().ToLower();
                
                    foreach (LineItems product in listOfLineItems)
                    {
                        if (_inputNames == product.Product.ProductName.ToLower())
                        {
                            Console.WriteLine($"   How Many {_inputNames} Orders Would You Like To Add?");
                            int _inputQuantity = int.Parse(Console.ReadLine().Trim());
                            product.StoreQuantity = 1;
                            
                            if (_inputQuantity <= 0)
                            {
                                Console.WriteLine($" You Must Enter A Quantity Higher Than 0" +
                                                "    Press Enter To Continue:");
                                Console.ReadLine();
                                return MenuType.PlaceOrder;
                            }
                            else if (_inputQuantity == 1)
                            {
                                SingletonCustomer.orders.LineItems.Add(product);
                                SingletonCustomer.orders.TotalPrice += (_inputQuantity * product.Product.ProductPrice);
                                Console.WriteLine($"   {_inputQuantity} {_inputNames} Order Has Been Added To The Shopping Cart" +
                                                "     Press Enter to continue");
                                Console.ReadLine();
                            }
                            else
                            {   
                                for (int i = 0; i < _inputQuantity; i++)
                                {
                                    SingletonCustomer.orders.LineItems.Add(product);
                                }
                                SingletonCustomer.orders.TotalPrice += (_inputQuantity * product.Product.ProductPrice);
                                Console.WriteLine(SingletonCustomer.orders);
                                Console.WriteLine($"   {_inputQuantity} {_inputNames} Orders Have Been Added To The Shopping Cart" +
                                                "      Press Enter To Continue: ");
                                Console.ReadLine();
                            }
                        }
                    }

                    return MenuType.PlaceOrder;
                case "2":
                    //--------- This Will Add The Order To The DataBase---------\\
                    SingletonCustomer.orders.CustomerId = SingletonCustomer.customers.CustomerId;
                    _customersBL.PlaceOrder(SingletonCustomer.customers, SingletonCustomer.orders);
                    
                    Console.WriteLine("   Order Has Been Placed" +
                                    "     Press Enter To Continue:");
                    Console.ReadLine();
                    return MenuType.MainMenu;
                case "x":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("   Please Enter A Valid Response!" +
                                    "     Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.PlaceOrder;
            }
        }
    }
}