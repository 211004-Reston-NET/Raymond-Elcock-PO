using System.Collections.Generic;
using Models;
using DataAccessLogic;

namespace BusinessLogic
{
    public interface IProductsBL
    {
        /// <summary>
        /// This will return a list of products stored in the database
        /// It will also capitalize every name of the products
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<Products> GetAllProducts();


        /// <summary>
        /// Adds a products to the database
        /// </summary>
        /// <param name="s_products">This is the products we are adding</param>
        /// <returns>It returns the added products</returns>
        Products AddProducts(Products s_products);

        /// <summary>
        /// Will find multiple products given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find products if their name has those letters</param>
        /// <returns>It will return products it found</returns>
        List<Products> GetProducts(string p_name);

        /// <summary>
        /// Will return a products based on the Id
        /// </summary>
        /// <param name="p_Id">This is the Id it will check</param>
        /// <returns>Returns products it found</returns>
        Products GetProductsById(int p_Id);



    }
}