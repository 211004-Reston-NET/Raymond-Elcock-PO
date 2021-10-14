using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;




namespace DataAccessLogic
{
    public class OrdersRepo : IRepository 
    {
         //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../DataAccessLogic/Database/Orders.json";
        private string _jsonString;

       

        public Orders AddOrders(Orders p_rest)
        {
          //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Orders> listOfOrders = GetAllOrders();

            //We added the new restaurant from the parameter 
            listOfOrders.Add(p_rest);

            _jsonString = JsonSerializer.Serialize(listOfOrders, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath,_jsonString);

            //Will return a restaurant object from the parameter
            return p_rest;
        }


        public List<Orders> GetAllOrders()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath);

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Orders>>(_jsonString);
        }
    }
}
        