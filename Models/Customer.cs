using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class Customer
    {
        //This is a field
        private string _customerName;
        public string Name {get; set;}

        private string _customerAddress;
        public string Address {get; set; }
        private string _customerPhoneNumber;
        public int PhoneNumber {get; set;}
        private string _customerEmail;
        public string Email {get; set;}

        

        //This is a property that uses the field called _name
        public string customerName
        {
            get { return _customerName; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                _customerName = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}";
        }

    }
}

 
