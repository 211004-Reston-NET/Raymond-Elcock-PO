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
        public class ProductsBL : IProductsBL
        {
            private ProductsRepo _products;
            /// <summary>
            /// We are defining the dependencies this class needs to operate
            /// We do it this way because we can easily switch out which implementation details we will be using
            /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
            /// have the implementation
            /// </summary>
            /// <param name="p_repo">It will pass in a Respository object</param>
            public ProductsBL(ProductsRepo p_products)
            {
                _products = p_products;
            }

        public Products AddProducts(Products s_products)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAllProducts()
            {
                //Maybe my business operation needs to capitalize every name of a restaurant
                List<Products> listOfProducts = _products.GetAllProducts();
                for (int i = 0; i < listOfProducts.Count; i++)
                {
                    listOfProducts[i].ProductName = listOfProducts[i].ProductName.ToLower(); 
                }

                return listOfProducts;
            }

            public List<Products> GetProducts(string p_name)
            {
                List<Products> listOfProducts = _products.GetAllProducts();
                
                //Select method will give a list of boolean if the condition was true/false
                //Where method will give the actual element itself based on some condition
                //ToList method will convert into List that our method currently needs to return.
                //ToLower will lowercase the string to make it not case sensitive
                return listOfProducts.Where(rest => rest.ProductName.ToLower().Contains(p_name.ToLower())).ToList();
            }
        }
    }