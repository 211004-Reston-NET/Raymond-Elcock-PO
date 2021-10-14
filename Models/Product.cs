using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;



namespace Models
{
    public class Products
    {
        private string _productName;
        public string ProductName {get; set;}
        
        private decimal _productPrice;
        public decimal ProductPrice {get; set;}

        private string _productDescription;
        public string ProductDescription {get; set;}

        private string _productCategory;
        public string ProductCategory {get; set;}
       
        
        
        //This is a property that uses the field called _name
        public string productName
        {
            get { return _productName; }
            
            set

            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the name field with a number
                    throw new Exception("Name can only hold letters!");
                }
                _productName = value;
                _productDescription = value;
                _productCategory = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {ProductName}\nDescription: {ProductDescription}\nCategory: {ProductCategory}";
        }

        
          
    }
}