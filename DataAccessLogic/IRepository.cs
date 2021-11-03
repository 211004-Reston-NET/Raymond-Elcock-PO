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
         /// <summary>
        ///     This will grab the current list of customers, then grab the current list of Orders for our selected Customer,
        ///     Then it will add our new order to the list and send back to the db.
        /// </summary>
        /// <param name="p_customers"> The customer that will be edited from the List of Customers </param>
        /// <param name="p_orders"> The Order that will be added to the list of Orders on our p_customer </param>
        /// <returns> Will return the Order that was placed. </returns>
        Orders PlaceOrder(Customers p_customers, Orders p_orders);
        /// <summary>
        /// Will update any values on a given customer. p_customer will contain the customer_id needed to locate the customer to update.
        /// </summary>
        /// <param name="p_customer"> the new values and id for the customer to update.</param>
        void UpdateCustomer(Models.Customers p_customers);

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
        LineItems AddLineItems(LineItems p_lineItems);

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
