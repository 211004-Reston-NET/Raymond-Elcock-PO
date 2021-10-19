using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Models
{
    public class LineItems
    { 
    private string _storeItems;
    public string StoreItems {get; set;}

    private string _storeQuantity;
    public string _StoreItemQuantity {get; set;}
       
     public string StoreAddress
        {
            get { return _storeItems; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                _storeItems = value;
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
