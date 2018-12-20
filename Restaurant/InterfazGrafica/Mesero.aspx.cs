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
    public partial class Mesero : System.Web.UI.Page
    {
        OrderLogic order = new OrderLogic();
        Order currentOrder;
        protected void Page_Load(object sender, EventArgs e)
        {
             //currentOrder = order.CreateOrder(1);
        }

        protected void anadir_orden_Click(object sender, EventArgs e)
        {
            

        }
    }
}