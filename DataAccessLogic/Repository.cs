using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;




namespace DataAccessLogic
{
    public class Repository : IRepository
    {
         //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../DataAccessLogic/Database/StoreFront.json";
        private string _jsonString;

        public static global::System.String Filepath => _filepath;

        public Stores AddStores(Stores p_rest)
        {
          //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Stores> listOfStores = GetAllStores();

            //We added the new restaurant from the parameter 
            listOfStores.Add(p_rest);

            _jsonString = JsonSerializer.Serialize(listOfStores, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the restaurant.json
            File.WriteAllText(Filepath,_jsonString);

            //Will return a restaurant object from the parameter
            return p_rest;
        }


        public List<Stores> GetAllStores()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(Filepath);

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Stores>>(_jsonString);
        }
    }
}
        
    
