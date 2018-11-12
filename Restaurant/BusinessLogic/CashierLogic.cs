using Entities;
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

        public List<Order> getOrders()
        {
            return OrderLogic.Orders;
        }

        public Order serchOrderByTable(int tableId)
        {
            foreach (Order order in OrderLogic.Orders)
            {
                if(order.Table == tableId )
                {
                    return order;
                }
            }
            return null;
        }

        public void AddOrderToBill(int orderId, int billId)
        {
            foreach (Order order in OrderLogic.Orders)
            {
                if (order.ID == orderId && order.Paid == false)
                {
                    billLo.AddOrder(billId, order);
                }
            }
        }

        public void PayBill(int billId)
        {
            foreach (Bill bill in BillLogic.Bills)
            {
                if(bill.ID == billId)
                {
                    foreach (Order order in bill.Orders)
                    {
                        orderLo.PayOrder(order);
                    }
                }
            }
        }
    }
}