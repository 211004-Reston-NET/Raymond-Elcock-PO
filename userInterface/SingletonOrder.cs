using Models;

namespace userInterface
{
    public class SingletonOrder
    {
        public static Orders Orders = new Orders();
        public static Orders orders = new Orders();
        public static string location { get; set; }
        public static StoreFronts storeFronts = new StoreFronts();

    }
}