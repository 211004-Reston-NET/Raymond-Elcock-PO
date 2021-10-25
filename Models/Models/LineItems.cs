using System;
using System.Text.RegularExpressions;


namespace Models
{
    public class LineItems
                { 
                private string _storeItems;
                private int _storeQuantity;
                public string StoreItems
                    {
                        get { return _storeItems; }
                        set 
                        {
                            //Main idea - this Regex will find me any number inside of my string
                            if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                            {
                                //Will give the user an exception whenever you try to set the city field with a number
                                throw new Exception("Items can only hold letters!");
                            }
                            _storeItems = value;
                        }
                    }
                    public int StoreQuantity 
                {
                        get { return _storeQuantity; }
                        set { _storeQuantity = value; }
                }

                    public override string ToString()
                    {
                        string Customers = 
                        $@"StoreItems: {StoreItems}
                        Quantity: {StoreQuantity}
                        
                        ";
                        
                        return Customers;   
                    }

                }
            }
