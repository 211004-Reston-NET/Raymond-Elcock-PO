using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class StoreFronts
    {
    

        private string _storeName;
        public string Name {get; set;}
        
        private string _storeAddress;
        public string Address {get; set;}

       

          //This is a property that uses the field called _name
        public string storeName
        {
            get { return _storeName; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                _storeName = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}";
        }

        


        
        // change back once learn more about datastructures
        //public List<Products> Products {get; set;}
        //public List<Orders> Orders {get; set;}
    }
}