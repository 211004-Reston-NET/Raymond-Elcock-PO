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
        private IStoreBL _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public StoreBL(IStoreBL p_repo)
        {
            _repo = p_repo;
        }

        public StoreBL AddStore(StoreBL s_front)
        {
            return _repo.AddStore(s_front);
        }

        public StoreBL AddStores(StoreBL s_front)
        {
            throw new NotImplementedException();
        }

        public List<StoreBL> GetAllStore()
        {
            throw new NotImplementedException();
        }

        public List<StoreBL> GetAllStores()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<StoreBL> listOfStores = _repo.GetAllStores();
            for (int i = 0; i < listOfStores.Count; i++)
            {
                listOfStores[i].StoreName = listOfStores[i].StoreName.ToLower(); 
            }

            return listOfStores;
        }

    }
}