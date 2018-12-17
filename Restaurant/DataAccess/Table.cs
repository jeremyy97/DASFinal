using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /// <summary>
    /// Entidad mesa, la cual es necesitada cada vez que deseamos realizar una orden.
    /// </summary>
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
