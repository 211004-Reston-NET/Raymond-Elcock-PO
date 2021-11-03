using System.Collections.Generic;
using Models;
using DataAccessLogic;

namespace BusinessLogic
{
    public interface IStoreFrontsBL
    {
        /// <summary>
        /// This will return a list of storefronts stored in the database
        /// It will also capitalize every name of the storefronts
        /// </summary>
        /// <returns>It will return a list of storefronts</returns>
        List<StoreFronts> GetAllStoreFronts();


        /// <summary>
        /// Adds a storefronts to the database
        /// </summary>
        /// <param name="s_front">This is the storefronts we are adding</param>
        /// <returns>It returns the added storefronts</returns>
        StoreFronts AddStoreFronts(StoreFronts p_storeFronts);

        /// <summary>
        /// Will find multiple storefronts given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find storefronts if their name has those letters</param>
        /// <returns>It will return storefronts it found</returns>
        StoreFronts GetStoreFronts(string p_name);

        /// <summary>
        /// Will return a storefronts based on the Id
        /// </summary>
        /// <param name="p_Id">This is the Id it will check</param>
        /// <returns>Returns storefronts it found</returns>
        StoreFronts GetStoreFrontsById(int p_Id);


    }
}