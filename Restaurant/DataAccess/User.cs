using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /// <summary>
    /// Entidad usuario, utilizada para iniciar sesion. Depende del valor Type para saber que recursos puede accesar cada usuario.
    /// </summary>
    public class User
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }
        public string LastName { set; get; }
        public string Type { set; get; }
        public int Availability { set; get; }

        public override string ToString()
        {
            return "Username: " + Username + " Name: " + Name + " " + LastName + " Type: " + Type;
        }
    }
}
    