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
    public class StoreBL: IStoreBL
    {
        
        private Repository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public StoreBL(Repository p_repo)
        {
            _repo = p_repo;
        }

        public StoreFront AddStore(StoreFront s_front)
        {
            return _repo.AddStores(s_front);
        }

              public List<StoreFront> GetAllStores()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<StoreFront> listOfStores = _repo.GetAllStores();
            for (int i = 0; i < listOfStores.Count; i++)
            {
                listOfStores[i].StoreName = listOfStores[i].StoreName.ToLower(); 
            }

            return listOfStores;
        }

        
    }
}