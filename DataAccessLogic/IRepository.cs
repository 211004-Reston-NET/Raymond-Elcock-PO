using System.Collections.Generic;
using Models;


namespace DataAccessLogic
{
    public interface IOrders
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_orders">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Orders AddOrders(Orders p_orders);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        
        List<Orders>GetAllOrders();
        List<Review> GetAllReview();
       

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
         List<Customers>GetAllCustomers();
         List<Review> GetAllReview();
         
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
         List<Products>GetAllProducts();
         List<Review> GetAllReview();
       
    }
    public interface ILineItems
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_lineItems">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        LineItems AddLineItems(LineItems p_lineItems);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
         List<LineItems>GetAllLineItems();
         List<Review> GetAllReview();
       
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
         List<StoreFronts>GetAllStoreFronts();
         List<Review> GetAllReview();
  }

}