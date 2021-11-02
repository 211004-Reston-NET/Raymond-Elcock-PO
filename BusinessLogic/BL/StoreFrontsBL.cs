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
        public class StoreFrontsBL: IStoreFrontsBL
        {
            
            private IStoreFronts _storeFronts;
            /// <summary>
            /// We are defining the dependencies this class needs to operate
            /// We do it this way because we can easily switch out which implementation details we will be using
            /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
            /// have the implementation
            /// </summary>
            /// <param name="p_repo">It will pass in a Respository object</param>
            public StoreFrontsBL(IStoreFronts p_storeFronts)
            {
                _storeFronts = p_storeFronts;
            }

            public StoreFronts AddStoreFronts(StoreFronts p_storeFronts)
        {
            if (p_storeFronts.StoreName == null || p_storeFronts.StoreAddress == null )
            {
                throw new Exception("You must have a value in all of the properties of the restaurant class");
            }

            return _storeFronts.AddStoreFronts(p_storeFronts);
        }

        public StoreFronts GetStoreFronts(string p_name)
        {
            List<StoreFronts> listOfStoreFronts = _storeFronts.GetAllStoreFronts();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfStoreFronts.FirstOrDefault(storeFronts => storeFronts.StoreName.ToLower() == p_name.ToLower());
        }


                public List<StoreFronts> GetAllStoreFronts()
            {
                //Maybe my business operation needs to capitalize every name of a restaurant
                List<StoreFronts> listOfStoreFronts = _storeFronts.GetAllStoreFronts();
                for (int i = 0; i < listOfStoreFronts.Count; i++)
                {
                    listOfStoreFronts[i].StoreName = listOfStoreFronts[i].StoreName.ToLower(); 
                }

                return listOfStoreFronts;
            }

        public StoreFronts GetStoreFrontsById(int p_Id)
        {
            StoreFronts storeFrontsFound = _storeFronts.GetStoreFrontsById(p_Id);

            if (storeFrontsFound == null)
            {
                throw new Exception("storeFronts was not found!");
            }

            return storeFrontsFound;
        }

    }
    }