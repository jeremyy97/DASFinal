using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /// <summary>
    /// Relacion entre las ordenes y las ordenes con un producto asignado. Se utilizada para la construccion de las ordenes con producto cuando obtenemos los valores desde la base de datos.
    /// Se funcion es unicamente de construccion
    /// </summary>
    public class Order_Product
    {
        public int ID { set; get; }
        public int Table_id { set; get; }
        public int Product_id { set; get; }
        public decimal Cost { set; get; }
        public int Paid { get; set; }
        public int Completed { get; set; }
    }
}
