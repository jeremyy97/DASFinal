using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    class Order
    {
        int ID { set; get; }
        List<Product> productos = new List<Product>();
    }
}
