using System.Collections.Generic;
using Models;




namespace DataAccessLogic
    {
              public interface IRepository
              {
                  
              } 
               
                public interface IOrders
            {
                /// <summary>
                /// It will add a restaurant in our database
                /// </summary>
                /// <param name="p_orders">This is the restaurant we will be adding to the database</param>
                /// <returns>It will just return the restaurant we are adding</returns>
                Orders AddOrders(Orders p_orders);


                /// <summary>
                /// This will return a list of orders stored in the database
                /// </summary>
                /// <returns>It will return a list of orderss</returns>
                
                List<Orders> GetAllOrders();
                 Orders GetOrdersById(int p_Id);
    }
            public interface ICustomers
            {
                /// <summary>
                /// It will add a restaurant in our database
                /// </summary>
                /// <param name="p_customers">This is the restaurant we will be adding to the database</param>
                /// <returns>It will just return the restaurant we are adding</returns>
                Customers AddCustomers(Customers p_customers);


                /// <summary>
                /// This will return a list of restaurants stored in the database
                /// </summary>
                /// <returns>It will return a list of restaurants</returns>
                List<Customers> GetAllCustomers();
                Customers GetCustomersById(int p_id);
       
    }
            public interface IProducts
            {
                /// <summary>
                /// It will add a restaurant in our database
                /// </summary>
                /// <param name="p_rest">This is the restaurant we will be adding to the database</param>
                /// <returns>It will just return the restaurant we are adding</returns>
                Products AddProducts(Products p_products);


                /// <summary>
                /// This will return a list of restaurants stored in the database
                /// </summary>
                /// <returns>It will return a list of restaurants</returns>
                List<Products> GetAllProducts();
    
                 Products GetProductsById(int p_id);
            
            }
            public interface ILineItems
            {
        Customers AddCustomers(Customers p_customers);

        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_lineItems">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        // LineItems AddLineItems(LineItems p_lineItems);


                /// <summary>
                /// This will return a list of restaurants stored in the database
                /// </summary>
                /// <returns>It will return a list of restaurants</returns>
                List<LineItems> GetAllLineItems();

                 LineItems GetLineItemsById(int p_id);

                 /// <summary>
                 /// This will return a list of line items that will reference a storefront
                 ///  </summary>
                 /// <param name="p_storeFrontID">this will be the storefonts id that will get searched for </param>
                 /// <returns>will return list of line items</returns>
                 List<LineItems> GetLineItemsByStoreID(int p_storeFrontID);
        
    }
            public interface IStoreFronts
            {
                /// <summary>
                /// It will add a restaurant in our database
                /// </summary>
                /// <param name="p_lineItems">This is the restaurant we will be adding to the database</param>
                /// <returns>It will just return the restaurant we are adding</returns>
                StoreFronts AddStoreFronts(StoreFronts p_storeFronts);


                /// <summary>
                /// This will return a list of restaurants stored in the database
                /// </summary>
                /// <returns>It will return a list of restaurants</returns>
                List<StoreFronts> GetAllStoreFronts();
             StoreFronts GetStoreFrontsById(int p_id);
        }

    }
