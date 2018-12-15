using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Table
    {
        public int ID { get; set; }
        public int People { get; set; }
        public int Available { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + " Cantidad de personas: " + People + " Disponible: " + Available;
        }
    }
}
