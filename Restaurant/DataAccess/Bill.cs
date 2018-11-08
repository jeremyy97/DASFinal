using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Bill
    {
        private static int Counter = 0;
        public int ID { set; get; }
        public string Client { set; get; }
        public List<Order> Orders = new List<Order>();
        public decimal Tax { get; set; }
        public decimal Price { get; set; }
        public decimal FinalPrice { get; set; }

        public Bill(string Client)
        {
            ID = Counter++;
            this.Client = Client;
            Orders = new List<Order>();
            Tax = 0;
            Price = 0;
            FinalPrice = 0;
        }
    }
}
