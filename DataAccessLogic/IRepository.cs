using System.Collections.Generic;
using Models;


namespace DataAccessLogic
{
    public interface IOrders
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="s_orders">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Orders AddOrders(Orders s_orders);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Orders>GetAllOrders();
       

    }
    public interface ICustomers
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="s_customers">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Customers AddCustomers(Customers s_customers);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
         List<Customers>GetAllCustomers();
       
    }
    public interface IProducts
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_rest">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Products AddProducts(Products s_products);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        
       
    }
    public interface ILineItems
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="l_items">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        LineItems AddLineItems(LineItems l_items);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
         List<LineItems>GetAllLineItems();
       
    }
  }

