﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class Customers
    {

        public Customers()
        {
            this.Name = "Name";
            this.Address = "Address";
            this.Phone = "Phone";
            this.Email = "Email";
            
        }
        //This is a field
        private string _name;
        private string _address;
        private string _phone;
        private string _email;
        private List<Orders> _orders = new List<Orders>();
        

        //This is a property that uses the field called _city
        public string Name
        {
            get { return _name; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[a-zA-Z]+(\s[a-zA-Z]+)?$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Name can only hold letters!");
                }
                _name = value;
            }
        }

         public string Address
        {
            get { return _address; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9'\.\-\s\,]"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Address can only hold letters and Numbers!");
                }
                _address = value;
            }
        }
        public string Phone
        {
            get { return _phone; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Phone Numbers can only hold Numbers!");
                }
                _phone = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Address can only hold letters and Numbers!");
                }
                _email = value;
            }
        }


        public List<Review> Reviews { get; set; }
        public List<Orders> Orders 
        {  
        get {return _orders;}    
        set {_orders = value;}
        }
        public override string ToString()
                {
                    string Customers = 
                    $@"Store Name: {Name}
                    Store Address: {Address}
                    Store Phone: {Phone}
                    Store Email : {Email}
                    List of Orders: {Orders}
                    ";
                    
                    return Customers;   




                }


    } 
}