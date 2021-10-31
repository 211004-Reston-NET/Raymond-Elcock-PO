using System.Collections.Generic;
using Models;
using DataAccessLogic;

namespace BusinessLogic
    {
        public interface IStoreFrontsBL
        {
            /// <summary>
            /// This will return a list of restaurants stored in the database
            /// It will also capitalize every name of the restaurant
            /// </summary>
            /// <returns>It will return a list of restaurants</returns>
            List<StoreFronts> GetAllStoreFronts();
            

            /// <summary>
            /// Adds a restaurant to the database
            /// </summary>
            /// <param name="s_front">This is the restaurant we are adding</param>
            /// <returns>It returns the added restaurant</returns>
            StoreFronts AddStoreFronts(StoreFronts p_storeFronts);

            /// <summary>
            /// Will find multiple restaurant given a name
            /// </summary>
            /// <param name="p_name">This is the string it will check to find restaurants if their name has those letters</param>
            /// <returns>It will return restaurants it found</returns>
            StoreFronts GetStoreFronts(string p_name);
            
            /// <summary>
        /// Will return a restaurant based on the Id
        /// </summary>
        /// <param name="p_Id">This is the Id it will check</param>
        /// <returns>Returns restaurant it found</returns>
        StoreFronts GetStoreFrontsById(int p_Id);

        /// <summary>
        /// This will give all the reviews from a restaurant
        /// </summary>
        /// <returns>It will return a list of reviews</returns>
        List<Review> GetAllReview(StoreFronts p_storeFronts);
        
        }
    }