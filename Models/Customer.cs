using System;
using System.Collections.Generic;
using static Models.StoreFront;

namespace Customer
{
    public class Customer
    {
        string name;

        string address;

        string email;

        int phoneNumber;

         public List<Models.Orders> Orders {get; set;}

    }
}
