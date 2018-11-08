using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Order
    {
        private static int counter = 0;
        public int ID { set; get; }
        public string Table { set; get; }
        public List<Product> Products = new List<Product>();
        public decimal Price { set; get; }
        public int Size { get; set; }
        public Boolean Active { get; set; }

        public Order(string Table)
        {
            ID = counter++;
            this.Table = Table;
            Products = new List<Product>();
            Price = 0;
            Size = 0;
            Active = true;
        }


    }
}
