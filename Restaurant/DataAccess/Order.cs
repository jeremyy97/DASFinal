using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Order
    {
        private static int counter = 0;
        public int ID { set; get; }
        public int Table { set; get; }
        public Product Product = new Product();
        public decimal Cost { set; get; }
        public Boolean Paid { get; set; }
        public Boolean Completed { get; set; }

        public Order(int Table)
        {
            ID = ++counter;
            this.Table = Table;
            Product = new Product();
            Cost = 0;
            Paid = false;
            Completed = false;
        }
        
    }
}
