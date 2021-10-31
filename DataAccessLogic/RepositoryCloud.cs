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
                        CustomerPhone = p_customers.Phone
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
                        Phone = customers.CustomerPhone,
                        CustomerId = customers.CustomerId


                    }
                ).ToList(); 
            }
        public Customers GetCustomersById(int p_id)
        {
             Entity.Customer customersToFind = _context.Customers.Find(p_id);
            
            return new Model.Customers(){
                CustomerId = customersToFind.CustomerId,
                Name = customersToFind.CustomerName,
                Address = customersToFind.CustomerAddress,
                Email = customersToFind.CustomerEmail,
                Phone = customersToFind.CustomerPhone,
               
                
            };
        }

        public List<Review> GetAllReview(Customers p_customers)
        {
           throw new System.NotImplementedException();
        }  
        
            public Model.Products AddProducts(Model.Products p_orders)
            {
                _context.Products.Add(
                    new Entity.Product()
                    {
                        ProductName = p_orders.ProductName,
                        ProductPrice = p_orders.ProductPrice,
                        ProductDescription =p_orders.ProductDescription,
                        ProductCategory =p_orders.ProductCategory,
                    }
                );
                _context.SaveChanges();

                return p_orders;
                
            }
            public List<Models.Products> GetAllProducts()
            {
                return _context.Products.Select(products =>
                    new Model.Products()
                    {
                        ProductName = products.ProductName,
                        ProductPrice = products.ProductPrice,
                        ProductDescription = products.ProductDescription,
                        ProductCategory = products.ProductCategory,
                        ProductId = products.ProductId,

                    }
                    
                ).ToList();
            }

            public List<Models.Products> GetAllProduct()
        {
            return _context.Products.Select(products =>
                    new Model.Products()
                    {
                        ProductName = products.ProductName,
                        ProductPrice = products.ProductPrice,
                        ProductDescription = products.ProductDescription,
                        ProductCategory = products.ProductCategory,
                        ProductId = products.ProductId


                    }
                ).ToList(); 
        }

        public Products GetProductsById(int p_id)
        {
            Entity.Product productsToFind = _context.Products.Find(p_id);
            
            return new Model.Products(){
                ProductId = productsToFind.ProductId,
                ProductName = productsToFind.ProductName,
                 ProductPrice = productsToFind.ProductPrice,
                ProductDescription = productsToFind.ProductDescription,
                ProductCategory = productsToFind.ProductCategory,
               
            
             };
            
        }

        public List<Review> GetAllReview(Products p_storeFronts)
        {
            throw new System.NotImplementedException();
        }
        public Model.LineItems AddLineItems(Model.LineItems p_lineItems)
        {
            _context.LineItems.Add(
                    new Entity.LineItem()
                    {
                        ProductName = p_lineItems.ProductName,
                        OrderStoreFrontAddress = p_lineItems.StoreAddress,
                        QuantityNumber =p_lineItems.StoreQuantity,
                    }
                   );
                _context.SaveChanges();

                return p_lineItems;
        }

        public List<LineItems> GetAllLineItems()
        {
            return _context.LineItems.Select(lineItems =>
                    new Model.LineItems()
                    {
                        ProductName = lineItems.ProductName,
                        StoreAddress = lineItems.OrderStoreFrontAddress,
                        StoreQuantity = lineItems.QuantityNumber,
                        LineItemId = lineItems.LineItemId,


                    }
                ).ToList(); 
            }

        public List<Review> GetAllReview(LineItems p_lineItems)
        {
            throw new System.NotImplementedException();
        }


        public LineItems GetLineItemsById(int p_id)
        {
          Entity.LineItem lineItemsToFind = _context.LineItems.Find(p_id);
            
            return new Model.LineItems(){
                LineItemId = lineItemsToFind.ProductId,
                ProductName = lineItemsToFind.ProductName,
                 StoreAddress = lineItemsToFind.OrderStoreFrontAddress,
                StoreQuantity = lineItemsToFind.QuantityNumber,
               
        };
        }

        public Orders AddOrders(Orders p_orders)
        {
            _context.StoreOrders.Add(
                    new Entity.StoreOrder()
                    {
                        StoreFrontAddress = p_orders.StoreAddress,
                        TotalPrice = p_orders.TotalPrice,
                    
                    
                    }
                );
                _context.SaveChanges();

                return p_orders;
        }
        public List<Orders> GetAllOrders()
        {
            return _context.StoreOrders.Select(orders =>
                    new Model.Orders()
                    {
                        StoreAddress = orders.StoreFrontAddress,
                        TotalPrice = orders.TotalPrice,
                        StoreOrderId = orders.StoreOrderId,


                    }
                ).ToList(); 
        }

        public List<Review> GetAllReview(Orders p_orders)
        {
            throw new System.NotImplementedException();
        }

        Orders IOrders.GetOrdersById(int p_Id)
        {
            Entity.StoreOrder ordersToFind = _context.StoreOrders.Find( p_Id);
            
            return new Model.Orders(){
                StoreOrderId = ordersToFind.StoreOrderId,
                StoreAddress = ordersToFind.StoreFrontAddress,
                 TotalPrice = ordersToFind.TotalPrice,
               
        };
        }

        public StoreFronts AddStoreFronts(StoreFronts p_storeFronts)
        {
            _context.StoreFronts.Add(
                    new Entity.StoreFront()
                    {
                        StoreFrontName = p_storeFronts.StoreName,
                        StoreFrontAddress = p_storeFronts.StoreAddress,
                        StoreFrontPhone = p_storeFronts.StorePhone,
                        
                    }
                );
                _context.SaveChanges();

                return p_storeFronts;
        }

        public List<StoreFronts> GetAllStoreFronts()
        {
            return _context.StoreFronts.Select(storeFronts =>
                    new Model.StoreFronts()
                    {
                        StoreName = storeFronts.StoreFrontName,
                        StoreAddress = storeFronts.StoreFrontAddress,
                        StorePhone = storeFronts.StoreFrontPhone,
                        StoreFrontId = storeFronts.StoreFrontId


                    }
                ).ToList(); 
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