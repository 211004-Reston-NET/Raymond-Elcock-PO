﻿
using System.Collections.Generic;
using Models;


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
            /// <param name="s_customers">This is the restaurant we are adding</param>
            /// <returns>It returns the added restaurant</returns>
            Customers AddCustomers(Customers p_customers);

            /// <summary>
            /// Will find multiple restaurant given a name
            /// </summary>
            /// <param name="p_name">This is the string it will check to find restaurants if their name has those letters</param>
            /// <returns>It will return restaurants it found</returns>
            List<Customers> GetCustomers(string p_name);   
        
        
        }
    }