using Models;

namespace userInterface
{
    public class SingletonCustomer
    {
        public static Customers customers = new Customers();
        public static Orders orders = new Orders();
        public static string location { get; set; }
        public static StoreFronts storeFronts = new StoreFronts();

    }
}