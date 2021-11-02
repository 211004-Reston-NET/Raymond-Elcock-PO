using System;
using System.Text.RegularExpressions;

namespace Models
{
    public class Products
    {
        private int _productId;
        private string _productName;
        private decimal _productPrice;
        private string _productDescription;
        private string _productCategory;

        //This is a property that uses the field called _name
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
            }
        }

        public string ProductDescription
        {
            get { return _productDescription; }
            set
            {
                _productDescription = value;
            }
        }
        public string ProductCategory
        {
            get { return _productCategory; }
            set
            {
                _productCategory = value;
            }
        }
        public decimal ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public override string ToString()
        {
            return $"Name: {ProductName} \nPrice: {ProductPrice} \nDescription: {ProductDescription} \nCategory: {ProductCategory}";
        }

    }


}

