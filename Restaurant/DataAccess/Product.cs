 using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return Name + ":" + "\nDescripción: " + Description + "\nCosto: ₡" + Cost + "\n\n";
        }

    }
}
