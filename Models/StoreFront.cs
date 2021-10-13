using System.Collections.Generic;

namespace Models
{
    public class StoreFront
    {
    

        private string _StoreName;
        public string StoreName {get; set;}
        
        string StoreAddress;
        public List<Products> Products {get; set;}
        public List<Orders> Orders {get; set;}
    }
}