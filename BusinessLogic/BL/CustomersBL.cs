using System;
using System.Collections.Generic;
using DataAccessLogic;
using Models;

namespace BusinessLogic
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class CustomersBL: ICustomersBL
    {
        
        private CustomersRepo _customers;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public CustomersBL(CustomersRepo p_customers)
        {
            _customers = p_customers;
        }

      public Customers AddCustomers(Customers p_customers)
        {
            if (p_customers.Name == null || p_customers.Address == null || p_customers.Email == null)
            {
                throw new Exception("You must have a value in all of the properties of customers class");
            }

            return _customers.AddCustomers(p_customers);
        }

        public List<Customers> GetAllCustomers()
        {
            //Maybe my business operation needs to capitalize every name of a customer
            List<Customers> listOfCustomers = _customers.GetAllCustomers();
            for (int i = 0; i < listOfCustomers.Count; i++)
            {
                listOfCustomers[i].Name = listOfCustomers[i].Name.ToLower(); 
            }

            return listOfCustomers;
        }
    }
}