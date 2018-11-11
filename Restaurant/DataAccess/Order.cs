using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Order
    {
        private static int counter = 0;
        public int ID { set; get; }
        public int Table { set; get; }
        public List<Product> Products = new List<Product>();
        public decimal Cost { set; get; }
        public int Size { get; set; }
        public Boolean Paid { get; set; }

        public Order(int Table)
        {
            ID = counter++;
            this.Table = Table;
            Products = new List<Product>();
            Cost = 0;
            Size = 0;
            Paid = true;
        }



    }
}
