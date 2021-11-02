using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class StoreFronts
    {
        private int _storeFrontId;
        private string _storeFrontName;
        private string _storeAddress;
        private string _storePhone;
        private List<Orders> _orders;
        private List<LineItems> _lineItems;


        //This is a property that uses the field called _name
        public int StoreFrontId
        {
            get { return _storeFrontId; }
            set { _storeFrontId = value; }
        }
        public string StoreName
        {
            get { return _storeFrontName; }
            set { _storeFrontName = value; }
        }
        public string StoreAddress
        {
            get { return _storeAddress; }
            set { _storeAddress = value; }
        }
        public string StorePhone
        {
            get { return _storePhone; }
            set
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9'\.\-\s\,]"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                _storePhone = value;
            }
        }

        public List<Orders> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public List<LineItems> LineItems
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }
        public override string ToString()
        {

            return $"StoreName: {StoreName} \nStoreAddress: {StoreAddress} \nStorePhone: {StorePhone} \nProducts: {LineItems} \nOrders: {Orders}";

        }

    }
}