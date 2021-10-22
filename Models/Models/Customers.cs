using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class Customers
    {
        //This is a field
        private string _customerName;
        private string _customerAddress;
        private string _phoneNumber;
        private string _customerEmail;
        private List<Orders> _orders = new List<Orders>();
        
       
        public string Name
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
        public string Address
        {
            get { return _customerAddress; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9'\.\-\s\,]"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Address can only hold letters and Numbers!");
                }
                _customerAddress = value;
            }
        }
       
        public string Phone
        {
            get { return _phoneNumber; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$"))
                {
                    //Phone number exception
                    throw new Exception("Not a valid phone number!");
                }
                _phoneNumber = value;
            }
        }
        public string Email
        {
            get { return _customerEmail; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                _customerEmail = value;
            }
        }
        public List<Orders> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        

        //This is a property that uses the field called _name
        

        public override string ToString()
        {
             string Customers = 
             $@"Name: {Name}
             Address: {Address}
             Phone: {Phone}
             Email : {Email}
             ";
            
            return Customers;   




        }
      }  
    
}

 
