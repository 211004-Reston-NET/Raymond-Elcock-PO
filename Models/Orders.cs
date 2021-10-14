using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Models
{
    public class Orders
    {
    private string _storeAddress;
    public string Address {get; set;}

    private decimal _totalPrice;
    public decimal OrderPrice {get; set;}
       
     public string StoreAddress
        {
            get { return _storeAddress; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                _storeAddress = value;
            }
        }

        public override string ToString()
        {
            return $"Name:Address: {StoreAddress}";
        }
        
      
       //Add Later
      //public List<ListItems>Item{get; set;}

    }
}