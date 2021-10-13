using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class Customer
    {
        //This is a field
        private string _name;

        //This is a property that uses the field called _name
        public string Name
        {
            get { return _name; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                _name = value;
            }
        }

        public string State { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nState: {State}";
        }

    }
}
{
    public class Customer
    {
        string name;

        string address;

        string email;

        int phoneNumber;

         public List<Models.Orders> Orders {get; set;}

    }
}
