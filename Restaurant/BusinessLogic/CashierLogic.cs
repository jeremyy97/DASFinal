using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class CashierLogic
    {
        OrderLogic orderLo;
        BillLogic billLo;

        public CashierLogic(OrderLogic orderLo, BillLogic billLo)
        {
            this.orderLo = orderLo;
            this.billLo = billLo;
        }


    }
}
