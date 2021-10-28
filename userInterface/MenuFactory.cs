
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BusinessLogic;
using DataAccessLogic;
using DataAccessLogic.Entities;


namespace userInterface
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder() //Configurationbuilder is the class that came from the Microsoft.extensions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) //Gets the current directory of the RRUI file path
                .AddJsonFile("AppSetting.JSON") //Adds the appsetting.json file in our RRUI
                .Build(); //Builds our configuration

            DbContextOptions<PODatabase1Context> options = new DbContextOptionsBuilder<PODatabase1Context>()
                .UseSqlServer(configuration.GetConnectionString("Reference2DB"))
                .Options;
            
            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomersMenu:
                    return new CustomersMenu();
                case MenuType.ShowCustomers:
                    return new ShowCustomers(new CustomersBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.AddCustomers:
                    return new AddCustomers (new CustomersBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.CurrentCustomers:
                    return new CurrentCustomers (new CustomersBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.LineItemsMenu:
                    return new LineItemsMenu();
                case MenuType.ShowLineItems:
                    return new ShowLineItems(new LineItemsBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.AddLineItems:
                    return new AddLineItems(new LineItemsBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.CurrentLineItems:
                    return new CurrentLineItems(new LineItemsBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.OrdersMenu:
                    return new OrdersMenu();
                case MenuType.ShowOrders:
                    return new ShowOrders(new OrdersBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.AddOrders:
                    return new AddOrders(new OrdersBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.CurrentOrders:
                    return new CurrentOrders(new OrdersBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.ProductsMenu:
                    return new ProductsMenu();
                case MenuType.ShowProducts:
                    return new ShowProducts(new ProductsBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.AddProducts:
                    return new AddProducts(new ProductsBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.CurrentProducts:
                    return new CurrentProducts(new ProductsBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.StoreFrontsMenu:
                    return new StoreFrontsMenu();
                case MenuType.ShowStoreFronts:
                    return new ShowStoreFronts(new StoreFrontsBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.AddStoreFronts:
                    return new AddStoreFronts(new StoreFrontsBL(new RepositoryCloud(new PODatabase1Context(options))));
                case MenuType.CurrentStoreFronts:
                    return new CurrentStoreFronts(new StoreFrontsBL(new RepositoryCloud(new PODatabase1Context(options))));
               
               
               
               
               
               
               
               
               
               
               default:
                    return null;
            }    
            
            
        }
    }
}