using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using Entities;

namespace InterfazGrafica
{
    public partial class Usuario : System.Web.UI.Page
    {
        UserLogic user = new UserLogic();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void crear_usuario_Click(object sender, EventArgs e)
        {
            //User NerUser = user.createUser("username", "pass", "name", "lastname", "type");
        }

        protected void agregar_usuario_Click(object sender, EventArgs e)
        {
            //User DeleteUser = user.EnableUser("username", "logged username");
        }

        protected void eliminar_usuario_Click(object sender, EventArgs e)
        {
            //User DeleteUser = user.DisableUser("username", "logged username");
        }
    }
}