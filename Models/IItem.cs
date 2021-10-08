namespace Models
{
      //This enum will hold the different types of Menu the user can go through
    //This helps to remove potential spelling mistakes in our program by making
    //Intellisense do the work for us
    public enum ItemType
    {
        MainMenu,
        RestaurantMenu,
        Exit
    }
    public class IItem
    {
        //This enum will hold the different types of Menu the user can go through
    //This helps to remove potential spelling mistakes in our program by making
    //Intellisense do the work for us
    public enum ItemType
    {
        //Products,
       // ,
       // Exit,
    }

    //The purpose of the interface is to ensure that every menu that we will create will have
    //the following methods in this case we can also use polymorphism
    public interface IIteam
    {
        /// <summary>
        /// Will display the overall menu of the current menu class 
        /// and the choice you/the user can make
        /// </summary>
        void Item();

            /// <summary>
            /// Will record the user's choice and change your menu based
            /// on the end-user's choice
            /// </summary>
            /// <returns>This method should return a menu that the user will go to next</returns>
            ItemType YourChoice { get; }
        }
    }
}