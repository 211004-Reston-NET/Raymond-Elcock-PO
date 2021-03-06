using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class Customers
    {


        //This is a field
        private int _customerId;
        private string _name;
        private string _address;
        private string _phone;
        private string _email;
        private List<Orders> _orders = new List<Orders>();


        //This is a property that uses the field called _name
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                
                _name = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                
                _address = value;
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Address can only hold letters and Numbers!");
                }
                _phone = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                
                _email = value;
            }
        }

        public List<Orders> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public string Password { get; set; }

        public override string ToString()
        {
            return $"Customer Name: {Name} \nCustomer Address: {Address} \nCustomer Email: {Email} \nCustomer Phone: {Phone}";




        }


    }
}