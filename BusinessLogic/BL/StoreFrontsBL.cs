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
    public class StoreFrontsBL: IStoreFrontsBL
    {
        
        private StoreFrontsRepo _storeFronts;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public StoreFrontsBL(StoreFrontsRepo p_storeFronts)
        {
            _storeFronts = p_storeFronts;
        }

        public StoreFronts AddStoreFronts(StoreFronts p_storeFronts)
        {
            return _storeFronts.AddStoreFronts(p_storeFronts);
        }

              public List<StoreFronts> GetAllStoreFronts()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<StoreFronts> listOfStoreFronts = _storeFronts.GetAllStoreFronts();
            for (int i = 0; i < listOfStoreFronts.Count; i++)
            {
                listOfStoreFronts[i].Name = listOfStoreFronts[i].Name.ToLower(); 
            }

            return listOfStoreFronts;
        }

        
    }
}