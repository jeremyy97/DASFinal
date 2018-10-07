using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Order
    {
        int ID { set; get; }
        string Table { set; get; }
        List<Product> products = new List<Product>();
    }
}
