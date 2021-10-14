using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Models
{
    public class ListItems
    { 
    private string _storeProduct;
    public string StoresProduct {get; set;}

    private decimal _storeQuantity;
    public decimal _StoreQuantity {get; set;}
       
     public string StoreAddress
        {
            get { return _storeProduct; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                _storeProduct = value;
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
