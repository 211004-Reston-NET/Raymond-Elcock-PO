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

        return new Model.Customers()
        {
            CustomerId = customersToFind.CustomerId,
            Name = customersToFind.CustomerName,
            Address = customersToFind.CustomerAddress,
            Email = customersToFind.CustomerEmail,
            Phone = customersToFind.CustomerPhone,


        };
    }




    public List<Replenish> GetAllReview(Customers p_customers)
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
                ProductDescription = p_orders.ProductDescription,
                ProductCategory = p_orders.ProductCategory,
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

        return new Model.Products()
        {
            ProductId = productsToFind.ProductId,
            ProductName = productsToFind.ProductName,
            ProductPrice = productsToFind.ProductPrice,
            ProductDescription = productsToFind.ProductDescription,
            ProductCategory = productsToFind.ProductCategory,


        };

    }

  


    public List<Replenish> GetAllReview(Products p_storeFronts)
    {
        throw new System.NotImplementedException();
    }
     

    public List<LineItems> GetAllLineItems()
    {
        return _context.LineItems.Select(lineItems =>
                new Model.LineItems()
                {
                    ProductId = lineItems.ProductId,
                    StoreFrontId = lineItems.StorefrontId,
                    StoreQuantity = lineItems.QuantityNumber,
                    LineItemId = lineItems.LineItemId,
                    Product = new Models.Products()
                    {
                        ProductName = lineItems.Product.ProductName,
                        ProductPrice = lineItems.Product.ProductPrice,
                        ProductDescription = lineItems.Product.ProductDescription,
                        ProductCategory = lineItems.Product.ProductCategory
                    }

                }
            ).ToList();
    }

    public List<Replenish> GetAllReview(LineItems p_lineItems)
    {
        throw new System.NotImplementedException();
    }


    public LineItems GetLineItemsById(int p_id)
    {
        Entity.LineItem lineItemsToFind = _context.LineItems.Find(p_id);

        return new Model.LineItems()
        {
            ProductId = lineItemsToFind.ProductId,
            StoreFrontId = lineItemsToFind.StorefrontId,
            StoreQuantity = lineItemsToFind.QuantityNumber,
            LineItemId = lineItemsToFind.LineItemId,
            Product = new Models.Products()
            {
                ProductName = lineItemsToFind.Product.ProductName,
                ProductPrice = lineItemsToFind.Product.ProductPrice,
                ProductDescription = lineItemsToFind.Product.ProductDescription,
                ProductCategory = lineItemsToFind.Product.ProductCategory
            }

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

    Orders IOrders.GetOrdersById(int p_Id)
    {
        Entity.StoreOrder ordersToFind = _context.StoreOrders.Find(p_Id);

        return new Model.Orders()
        {
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

    public List<Replenish> GetAllReview(StoreFronts p_storeFronts)
    {
        throw new System.NotImplementedException();
    }

    public StoreFronts GetStoreFrontsById(int p_id)
    {
        Entity.StoreFront storeFrontsToFind = _context.StoreFronts.Find(p_id);

        return new Model.StoreFronts()
        {
            StoreFrontId = storeFrontsToFind.StoreFrontId,
            StoreName = storeFrontsToFind.StoreFrontName,
            StoreAddress = storeFrontsToFind.StoreFrontAddress,

        };
    }

    public List<LineItems> GetLineItemsByStoreID(int p_storeFrontID)
    {
        return _context.LineItems
                    .Where(li => li.StorefrontId == p_storeFrontID)
                    .Select(lineItems =>
                    new Model.LineItems()
                    {
                        ProductId = lineItems.ProductId,
                        StoreFrontId = lineItems.StorefrontId,
                        StoreQuantity = lineItems.QuantityNumber,
                        LineItemId = lineItems.LineItemId,
                        Product = new Models.Products()
                        {
                            ProductName = lineItems.Product.ProductName,
                            ProductPrice = lineItems.Product.ProductPrice,
                            ProductDescription = lineItems.Product.ProductDescription,
                            ProductCategory = lineItems.Product.ProductCategory
                        }
                    }
                ).ToList();
    }

    public LineItems AddLineItems(LineItems p_lineItems)
    {
         _context.LineItems.Add(
                new Entity.LineItem()
                {
                    
                    QuantityNumber = p_lineItems.StoreQuantity,
                   

                }
            );
        _context.SaveChanges();

        return p_lineItems;
    }

    public Orders PlaceOrder(Customers p_customers, Orders p_orders)
    {
        var foundCustomer = _context.Customers
                                 .First<Entity.Customer>(cust => cust.CustomerId == p_customers.CustomerId);
        foundCustomer.StoreOrders.Add(new Entity.StoreOrder()
        {
                
                StoreFrontAddress = p_orders.StoreAddress,
                TotalPrice = p_orders.TotalPrice,
                StoreFrontId = p_orders.StoreFrontId,
                CustomersId = p_orders.CustomerId,
        });
        _context.SaveChanges();
        return p_orders;
    }

    public void UpdateCustomer(Customers p_customers)
    {
        throw new System.NotImplementedException();
    }
}
