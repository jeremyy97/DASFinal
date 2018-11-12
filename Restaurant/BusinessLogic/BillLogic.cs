﻿using System;

using System.Collections.Generic;
using System.Text;
using Entities;

namespace BusinessLogic
{
    public class BillLogic
    {
        List<Bill> Bills = new List<Bill>();

        public string AddOrder(int id, Order order)
        {
            foreach (var bill in Bills)
            {
                if (bill.ID == id)
                {
                    bill.Orders.Add(order);
                    return "La orden fue agregada a la factura";
                }
            }
            return "No se encontro factura con este ID";
        }




    }
}
