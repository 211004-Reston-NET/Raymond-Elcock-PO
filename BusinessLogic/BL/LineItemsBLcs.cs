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
    public class LineItemsBL: ILineItemsBL
    {
        
        private LineItemsRepo _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public LineItemsBL(LineItemsRepo p_repo)
        {
            _repo = p_repo;
        }

        public LineItems AddLineItems(LineItems p_lineItems)
        {
            return _repo.AddLineItems(p_lineItems);
        }

              public List<LineItems> GetAllLineItems()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<LineItems> listOfLineItems = _repo.GetAllLineItems();
            for (int i = 0; i < listOfLineItems.Count; i++)
            {
                listOfLineItems[i].StoreItems = listOfLineItems[i].StoreItems.ToLower(); 
            }

            return listOfLineItems;
        }

        public List<LineItems> GetAllListItems()
        {
            throw new NotImplementedException();
        }
    }
}