using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace InterfazGrafica
{
    public partial class Cliente : System.Web.UI.Page
    {
        OrderLogic order = new OrderLogic();
        public static  int mesa = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void anadir_orden_Click(object sender, EventArgs e)
        {
            
        }
    }
}