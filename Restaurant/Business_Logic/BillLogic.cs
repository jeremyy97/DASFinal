using System;

using System.Collections.Generic;
using System.Text;
using Entities;

namespace BusinessLogic
{
    public class BillLogic
    {
        public static List<Bill> Bills = new List<Bill>();

        public int CreateBill(string clientName)
        {
            Bill bill = new Bill(clientName);
            int BillId = bill.ID;
            Bills.Add(bill);
            return BillId;
        }
        public string AddOrder(int billId, Order order)
        {
            foreach (var bill in Bills)
            {
                if (bill.ID == billId)
                {
                    bill.Orders.Add(order);
                    return "La orden fue agregada a la factura";
                }
            }
            return "No se encontro factura con este ID";
        }




    }
}
