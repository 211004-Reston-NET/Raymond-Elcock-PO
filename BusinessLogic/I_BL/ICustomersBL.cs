
using System.Collections.Generic;
using Models;
using DataAccessLogic;

namespace BusinessLogic
{
      public interface ICustomersBL
    {
        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// It will also capitalize every name of the restaurant
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Customers> GetAllCustomers();
        

        /// <summary>
        /// Adds a restaurant to the database
        /// </summary>
        /// <param name="s_front">This is the restaurant we are adding</param>
        /// <returns>It returns the added restaurant</returns>
        Customers AddCustomers(Customers s_front);
        
       
     
    }
}