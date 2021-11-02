using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Models
{
    public class LineItems
    {
        private int _lineItemId;

        private decimal _storeQuantity;
        private List<LineItems> _lineItems = new List<LineItems>();
        public int LineItemId
        {
            get { return _lineItemId; }
            set { _lineItemId = value; }
        }
        private Products _product;
        public Products Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public int ProductId { get; set; }
        public int StoreFrontId { get; set; }

        public decimal StoreQuantity
        {
            get { return _storeQuantity; }
            set { _storeQuantity = value; }
        }

        public List<LineItems> LineItem
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }

        public override string ToString()
        {
            return $"ProductName: {Product.ProductName} \nQuanitity: {StoreQuantity} \nDescription: {Product.ProductDescription} \nCategory: {Product.ProductCategory} \nPrice: ${Product.ProductPrice}";
        }

    }
}
