using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Bill
    {
        int ID { set; get; }
        string Client { set; get; }
        List<Order> orders = new List<Order>();
    }
}
