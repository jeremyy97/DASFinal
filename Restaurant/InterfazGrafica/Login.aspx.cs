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

    public partial class Login : System.Web.UI.Page
    {
        UserLogic user = new UserLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            User loggedUser = user.Login(username.Text, password.Text);
            if ( loggedUser != null)
            {
                switch (loggedUser.Type)
                {
                    case "admin":
                        break;
                    case "waiter":
                        Response.Redirect("Mesero.aspx");
                        break;
                    case "table":
                        Response.Redirect("Cliente.aspx");
                        break;
                    case "cashier":
                        Response.Redirect("Cajero.aspx");
                        break;
                }
                Response.Redirect("Default.aspx");
            }
            else if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
                message.Text = "Por favor ingrese su usuario y contraseña.";
            else
                message.Text = "El usuario o la contraseña son incorrectos.";

        }
    }
}