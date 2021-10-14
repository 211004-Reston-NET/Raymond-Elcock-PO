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
    public class OrdersBL: IOrdersBL
    {
        
        private OrdersRepo _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public OrdersBL(OrdersRepo p_repo)
        {
            _repo = p_repo;
        }

        public Orders AddOrders(Orders s_front)
        {
            return _repo.AddOrders(s_front);
        }

              public List<Orders> GetAllOrders()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Orders> listOfOrders = _repo.GetAllOrders();
            for (int i = 0; i < listOfOrders.Count; i++)
            {
                listOfOrders[i].StoresAddress = listOfOrders[i].StoresAddress.ToLower(); 
            }

            return listOfOrders;
        }

        
    }
}