using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;




namespace DataAccessLogic
{
    public class ProductsRepo : IProducts
    {
         //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../DataAccessLogic/Database/";
        private string _jsonString;

       

        public Products AddProducts(Products p_products)
        {
          //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Products> listOfProducts = GetAllProducts();

            //We added the new restaurant from the parameter 
            listOfProducts.Add(p_products);

            _jsonString = JsonSerializer.Serialize(listOfProducts, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath+"Products.JSON",_jsonString);

            //Will return a restaurant object from the parameter
            return p_products;
        }


        public List<Products> GetAllProducts()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"Products.JSON");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Products>>(_jsonString);
        }

        public List<Review> GetAllReview()
        {
            throw new NotImplementedException();
        }
    }
}
        