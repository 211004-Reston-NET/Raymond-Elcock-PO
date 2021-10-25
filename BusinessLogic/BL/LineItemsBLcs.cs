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
        public class LineItemsBL: ILineItemsBL
        {
            
            private LineItemsRepo _lineItems;
            /// <summary>
            /// We are defining the dependencies this class needs to operate
            /// We do it this way because we can easily switch out which implementation details we will be using
            /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
            /// have the implementation
            /// </summary>
            /// <param name="p_repo">It will pass in a Respository object</param>
            public LineItemsBL(LineItemsRepo p_lineItems)
            {
                _lineItems = p_lineItems;
            }

            public LineItems AddLineItems(LineItems s_items)
            {
                throw new NotImplementedException();
            }

            public List<LineItems> GetAllLineItems()
            {
                //Maybe my business operation needs to capitalize every name of a restaurant
                List<LineItems> listOfLineItems = _lineItems.GetAllLineItems();
                for (int i = 0; i < listOfLineItems.Count; i++)
                {
                    listOfLineItems[i].StoreItems = listOfLineItems[i].StoreItems.ToLower(); 
                }

                return listOfLineItems;
            }

            public List<LineItems> GetLineItems(string p_name)
            {
                List<LineItems> listOfLineItems = _lineItems.GetAllLineItems();
                
                //Select method will give a list of boolean if the condition was true/false
                //Where method will give the actual element itself based on some condition
                //ToList method will convert into List that our method currently needs to return.
                //ToLower will lowercase the string to make it not case sensitive
                return listOfLineItems.Where(lineItems => lineItems.StoreItems.ToLower().Contains(p_name.ToLower())).ToList();
            }

        
        }
    }