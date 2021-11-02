using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;




namespace DataAccessLogic
{
    public class StoreFrontsRepo : IRepository
    {
        //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../DataAccessLogic/.JSON/";
        private string _jsonString;



        public StoreFronts AddStoreFronts(StoreFronts p_storeFronts)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<StoreFronts> listOfStoreFronts = GetAllStoreFronts();

            //We added the new restaurant from the parameter 
            listOfStoreFronts.Add(p_storeFronts);

            _jsonString = JsonSerializer.Serialize(listOfStoreFronts, new JsonSerializerOptions { WriteIndented = true });

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath + "StoreFronts.JSON", _jsonString);

            //Will return a restaurant object from the parameter
            return p_storeFronts;
        }

        public List<StoreFronts> GetAllStoreFronts()
        {

            try
            {
                _jsonString = File.ReadAllText(_filepath + "StoreFronts.JSON");
            }
            //This will catch a very specific exception and run the block
            catch (System.IO.FileNotFoundException)
            {
                //Added Dummy data
                StoreFronts newstoreFronts = new StoreFronts();
                List<StoreFronts> listOfStoreFronts = new List<StoreFronts>();
                listOfStoreFronts.Add(newstoreFronts);

                //Added a file to database folder
                File.WriteAllText(_filepath + "StoreFronts.JSON", JsonSerializer.Serialize<List<StoreFronts>>(listOfStoreFronts));

                //Read that file I just added
                _jsonString = File.ReadAllText(_filepath + "StoreFronts.JSON");
            }


            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<StoreFronts>>(_jsonString);
        }

        public List<Review> GetAllReview()
        {
            _jsonString = File.ReadAllText(_filepath + "Review.JSON");

            return JsonSerializer.Deserialize<List<Review>>(_jsonString);
        }
    }
}
