using System.Collections.Generic;

namespace Models
{
    public class StoreFront
    {
        string StoreName;
        string StoreAddress;
        public List<Products> Products {get; set;}
        public List<Orders> Orders {get; set;}
    }
}