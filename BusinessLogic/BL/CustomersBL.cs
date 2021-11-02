using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLogic;
using Models;

namespace BusinessLogic
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class CustomersBL :ICustomersBL
    {
        private ICustomers _customers;
        
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_customers">It will pass in a Respository object</param>
        public CustomersBL(ICustomers p_customers )
        {
            _customers = p_customers;
           
        }

        public Customers AddCustomers(Customers p_customers)
        {
            if (p_customers.Name == null || p_customers.Address == null || p_customers.Email == null)
            {
                throw new Exception("You must have a value in all of the properties of the restaurant class");
            }

            return _customers.AddCustomers(p_customers);
        }

        public List<Customers> GetAllCustomers()
        
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Customers> listOfCustomers = _customers.GetAllCustomers();
            for (int i = 0; i < listOfCustomers.Count; i++)
            {
                listOfCustomers[i].Name = listOfCustomers[i].Name.ToLower(); 
            }

            return listOfCustomers;
        }

        

    

        public Customers GetCustomers(string p_name)
        {
            List<Customers> listOfCustomers = _customers.GetAllCustomers();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfCustomers.FirstOrDefault(customers => customers.Name.ToLower() == p_name.ToLower());
        }

        public Customers GetCustomersById(int p_Id)
        {
            Customers customersFound = _customers.GetCustomersById(p_Id);

            if (customersFound == null)
            {
                throw new Exception("Customers was not found!");
            }

            return customersFound;
        }

        

        
    }
}
       