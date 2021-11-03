using System.Collections.Generic;
using Models;


namespace BusinessLogic
{
    public interface ILineItemsBL
    {
        /// <summary>
        /// This will return a list of line items stored in the database
        /// It will also capitalize every name of the line items
        /// </summary>
        /// <returns>It will return a list of line items</returns>
        List<LineItems> GetAllLineItems();
        List<LineItems> GetLineItems(int storeFrontId);



        /// <summary>
        /// Adds a line items to the database
        /// </summary>
        /// <param name="s_items">This is the line items we are adding</param>
        /// <returns>It returns the added line items</returns>
        // LineItems AddLineItems(LineItems s_items);

        /// <summary>
        /// Will find multiple line items given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find line items if their name has those letters</param>
        /// <returns>It will return line items it found</returns>
        LineItems GetLineItems(string p_name);


        /// <summary>
        /// Will return a line items based on the Id
        /// </summary>
        /// <param name="p_Id">This is the Id it will check</param>
        /// <returns>Returns line items it found</returns>
        LineItems GetLineItemsById(int p_Id);



        /// <summary>
        /// This will return a list of line items that will reference a storefront
        ///  </summary>
        /// <param name="p_storeFrontID">this will be the storefonts id that will get searched for </param>
        /// <returns>will return list of line items</returns>
        List<LineItems> GetLineItemsByStoreID(int p_storeFrontID);

    }
}