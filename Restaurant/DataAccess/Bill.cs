using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Bill
    {
        private static int counter = 0;
        public int ID { set; get; }
        public string Client { set; get; }
        public List<Order> orders = new List<Order>();
        public decimal Tax { get; set; }
        public decimal Price { get; set; }
        public decimal FinalPrice { get; set; }

        public Bill(string Client)
        {
            ID = counter++;
            this.Client = Client;
            orders = new List<Order>();
            Tax = 0;
            Price = 0;
            FinalPrice = 0;
        }
    }
}
