 using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /// <summary>
    /// Entidad producto, es utilizada cada vez que deseamos realizar una orden. 
    /// </summary>
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return "ID #" + ID + " " + Name + ":" + "\nDescripción: " + Description + "\nCosto: ₡" + Cost + "\n\n";
        }

    }
}
