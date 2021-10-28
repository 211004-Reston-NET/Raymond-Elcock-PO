using System.Collections.Generic;
using System.Linq;
using DataAccessLogic;
using Models;
using Entity = DataAccessLogic.Entities;
using Model = Models;


public class RepositoryCloud : ICustomers, ILineItems, IOrders, IProducts, IStoreFronts, IRepository
    {
         private Entity.PODatabase1Context _context;
        public RepositoryCloud(Entity.PODatabase1Context p_context) 
        {
            _context = p_context;
        }
        
        
        public Model.Customers AddCustomers(Model.Customers p_customers)
        {
            _context.Customers.Add(
                new Entity.Customer()
                {
                    CustomerName = p_customers.Name,
                    CustomerAddress = p_customers.Address,
                    CustomerEmail = p_customers.Email,
                }
            );
            _context.SaveChanges();

            return p_customers;
            

        }

        public List<Models.Customers> GetAllCustomers()
        {
            return _context.Customers.Select(customers =>
                new Model.Customers()
                {
                    Name = customers.CustomerName,
                    Address = customers.CustomerAddress,
                    Email = customers.CustomerEmail,
                    CustomerId = customers.CustomerId


                }
              ).ToList(); 
        }

        public List<Models.Review> GetAllReview()
        {
            throw new System.NotImplementedException();
        }
        public Customers GetCustomersById(int p_id)
    {
        throw new System.NotImplementedException();
    }
        
        
        
        
        public Models.LineItems AddLineItems(Models.LineItems p_lineItems)
        {
            throw new System.NotImplementedException();
        }

        public List<Models.LineItems> GetAllLineItems()
        {
            throw new System.NotImplementedException();
        }
        
        
        public Models.Orders AddOrders(Models.Orders p_orders)
        {
            throw new System.NotImplementedException();
        }

        public List<Models.Orders> GetAllOrders()
        {
            throw new System.NotImplementedException();
        }
        
        
        public Models.Products AddProducts(Models.Products p_products)
        {
            throw new System.NotImplementedException();
        }

        public List<Models.Products> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }
        
        
        public Models.StoreFronts AddStoreFronts(Models.StoreFronts p_storeFronts)
        {
            throw new System.NotImplementedException();
        }

        public List<Models.StoreFronts> GetAllStoreFronts()
        {
            throw new System.NotImplementedException();
        }

    public List<Review> GetAllReview(Customers p_customers)
    {
        throw new System.NotImplementedException();
    }

    public List<Review> GetAllReview(LineItems p_lineItems)
    {
        throw new System.NotImplementedException();
    }

    public LineItems GetLineItemsById(int p_id)
    {
        throw new System.NotImplementedException();
    }

    public LineItems GetRestaurantById(int p_Id)
    {
        throw new System.NotImplementedException();
    }

    public List<Review> GetAllReview(Orders p_orders)
    {
        throw new System.NotImplementedException();
    }

    Orders IOrders.GetRestaurantById(int p_Id)
    {
        throw new System.NotImplementedException();
    }

    public List<Review> GetAllReview(Products p_products)
    {
        throw new System.NotImplementedException();
    }

    public Products GetProductsById(int p_id)
    {
        throw new System.NotImplementedException();
    }

    public List<Review> GetAllReview(StoreFronts p_storeFronts)
    {
        throw new System.NotImplementedException();
    }

    public StoreFronts GetStoreFrontsById(int p_id)
    {
        throw new System.NotImplementedException();
    }

    
}