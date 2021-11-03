using System.Collections.Generic;
using Models;
using DataAccessLogic;

namespace BusinessLogic
{
    public interface IOrdersBL
    {
        /// <summary>
        /// This will return a list of orders stored in the database
        /// It will also capitalize every name of the orders
        /// </summary>
        /// <returns>It will return a list of orders</returns>
        List<Orders> GetAllOrders();


        /// <summary>
        /// Adds a orders to the database
        /// </summary>
        /// <param name="p_orders">This is the orders we are adding</param>
        /// <returns>It returns the added orders</returns>
        Orders AddOrders(Orders p_orders);

        /// <summary>
        /// Will find multiple orders given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find orders if their name has those letters</param>
        /// <returns>It will return orders it found</returns>
        List<Orders> GetOrders(string p_name);

        /// <summary>
        /// Will return a orders based on the Id
        /// </summary>
        /// <param name="p_Id">This is the Id it will check</param>
        /// <returns>Returns orders it found</returns>
        Orders GetOrdersById(int p_Id);



    }
}