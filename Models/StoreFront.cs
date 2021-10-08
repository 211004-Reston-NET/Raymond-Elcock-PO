using System.Collections.Generic;

namespace Models
{
    public class StoreFront
    {
        string StoreName;
        string StoreAddress;
        public List<Product> Products {get; set;}
        public List<Orders> Orders {get; set;}
    }
}