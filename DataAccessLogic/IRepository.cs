﻿using System.Collections.Generic;
using Models;

namespace DataAccessLogic
{
    public interface IRepository 
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_rest">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        StoreFront AddStores(StoreFront p_rest);

        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<StoreFront> GetAllStores ();
    }
}