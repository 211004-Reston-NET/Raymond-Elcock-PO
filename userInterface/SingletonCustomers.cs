using Models;

namespace userInterface
{
        public class SingletonCustomers
        {
                public static Customers customers = new Customers();
                public static Orders orders = new Orders();
                public static string location { get; set; }         
        }
    }