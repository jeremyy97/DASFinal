using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Order_Product
    {
        public int ID { set; get; }
        public int Table { set; get; }
        public int Product { set; get; }
        public decimal Cost { set; get; }
        public int Paid { get; set; }
        public int Completed { get; set; }
    }
}
