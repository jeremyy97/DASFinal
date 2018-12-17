using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /// <summary>
    /// Entiad factura contempla todas las facturas que se desean pagar en una sola factura.
    /// </summary>
    public class Bill
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Orders { get; set; }
        public decimal Tax { get; set; }
        public decimal Cost { get; set; }
        public decimal FinalCost { get; set; }

    }
}
