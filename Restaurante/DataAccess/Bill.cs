using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class Bill
    {
        int ID { set; get; }
        List<Product> productos = new List<Product>();
        string Client { set; get; }
        int Total { set; get; }
    }
}
