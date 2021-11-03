
using System.Collections.Generic;
using Models;


namespace BusinessLogic
{
    public interface ICustomersBL
    {
        /// <summary>
        /// This will return a list of customers stored in the database
        /// It will also capitalize every name of the customers
        /// </summary>
        /// <returns>It will return a list of customers</returns>
        List<Customers> GetAllCustomers();

        /// <summary>
        /// Adds a customers to the database
        /// </summary>
        /// <param name="s_customers">This is the customers we are adding</param>
        /// <returns>It returns the added customers</returns>
        Customers AddCustomers(Customers p_customers);

        /// <summary>
        /// Will find multiple customers given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find customers if their name has those letters</param>
        /// <returns>It will return customers it found</returns>
        Customers GetCustomers(string p_name);

        /// <summary>
        /// Will return a customers based on the Id
        /// </summary>
        /// <param name="p_Id">This is the Id it will check</param>
        /// <returns>Returns customers it found</returns>
        Customers GetCustomersById(int p_Id);
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
}