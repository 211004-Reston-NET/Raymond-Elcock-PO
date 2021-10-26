using BusinessLogic;
using DataAccessLogic;

namespace userInterface
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomersMenu:
                    return new CustomersMenu();
                case MenuType.ShowCustomers:
                    return new ShowCustomers(new CustomersBL(new CustomersRepo()));
                case MenuType.AddCustomers:
                    return new AddCustomers(new CustomersBL(new CustomersRepo()));
                case MenuType.CurrentCustomers:
                    return new CurrentCustomers(new CustomersBL(new CustomersRepo()));
                case MenuType.LineItemsMenu:
                    return new LineItemsMenu();
                case MenuType.ShowLineItems:
                    return new ShowLineItems(new LineItemsBL(new LineItemsRepo()));
                case MenuType.AddLineItems:
                    return new AddLineItems(new LineItemsBL(new LineItemsRepo()));
                case MenuType.CurrentLineItems:
                    return new CurrentLineItems(new LineItemsBL(new LineItemsRepo()));
                case MenuType.OrdersMenu:
                    return new OrdersMenu();
                case MenuType.ShowOrders:
                    return new ShowOrders(new OrdersBL(new OrdersRepo()));
                case MenuType.AddOrders:
                    return new AddOrders(new OrdersBL(new OrdersRepo()));
                case MenuType.CurrentOrders:
                    return new CurrentOrders(new OrdersBL(new OrdersRepo()));
                case MenuType.ProductsMenu:
                    return new ProductsMenu();
                case MenuType.ShowProducts:
                    return new ShowProducts(new ProductsBL(new ProductsRepo()));
                case MenuType.AddProducts:
                    return new AddProducts(new ProductsBL(new ProductsRepo()));
                case MenuType.CurrentProducts:
                    return new CurrentProducts(new ProductsBL(new ProductsRepo()));
                case MenuType.StoreFrontsMenu:
                    return new StoreFrontsMenu();
                case MenuType.ShowStoreFronts:
                    return new ShowStoreFronts(new StoreFrontsBL(new StoreFrontsRepo()));
                case MenuType.AddStoreFronts:
                    return new AddStoreFronts(new StoreFrontsBL(new StoreFrontsRepo()));
                case MenuType.CurrentStoreFronts:
                    return new CurrentStoreFronts(new StoreFrontsBL(new StoreFrontsRepo()));
               
               
               
               
               
               
               
               
               
               
               default:
                    return null;
            }    
            
            
        }
    }
}