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
            if (user.Login(username.Text, password.Text) != null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {

            }
        }
    }
}