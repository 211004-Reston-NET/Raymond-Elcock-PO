
using System.Collections.Generic;


namespace BusinessLogic
{
      public interface IStoreBL
    {
        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// It will also capitalize every name of the restaurant
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<StoreBL> GetAllStore();

        /// <summary>
        /// Adds a restaurant to the database
        /// </summary>
        /// <param name="s_front">This is the restaurant we are adding</param>
        /// <returns>It returns the added restaurant</returns>
        StoreBL AddStore(StoreBL s_front);
        StoreBL AddStores(StoreBL s_front);
        List<StoreBL> GetAllStores();
    }
}