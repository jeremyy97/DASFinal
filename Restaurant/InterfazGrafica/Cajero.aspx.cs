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
   

    public partial class Cajero : System.Web.UI.Page
    {
        BillLogic bill = new BillLogic();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pagar_cuenta_Click(object sender, EventArgs e)
        {
            //Bill billToPay = bill.CreateBill(1,"name");
        }
    }
}