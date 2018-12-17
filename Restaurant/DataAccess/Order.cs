using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /// <summary>
    /// Entidad orden, nos indica la mesa y el producto que se pidio. Se utiliza en la creacion de la factura Bill 
    /// </summary>
    public class Order
    {
        public int ID { set; get; }
        public int Table { set; get; }
        public Product Product = new Product();
        public decimal Cost { set; get; }
        public int Paid { get; set; }
        public int Completed { get; set; }

        public Order()
        {

        }
        
    }
}
