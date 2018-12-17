using System;
using System;
using System.Collections.Generic;
using System.Text;
using DBAccess;
using Entities;

namespace BusinessLogic
{
    public class BillLogic
    {
        public static List<Bill> Bills = new List<Bill>();

        public static decimal CostaRicaTax = 0.13m; //IMPUESTO COSTA RICA
        public OrderLogic Orders = new OrderLogic();

        public List<Order> OrdersToPayInTheSameTable { get; set; } //ORDENES POR PAGAR DE LA MISMA MESA
        public decimal Cost { get; set; } //SUMANDO EL COSTO
        public int Table { get; set; } //MESA A LA CUAL SE ESTA FACTURANDO
        public StringBuilder BillOrders { get; set; } //COMO PUEDE TENER VARIAS ORDENES, MEJOR USAR UN STRING PARA LA BD

        public BillLogic(int Table) //CUANDO UN CAJERO VAYA A FACTURAR MANDE OBLIGATORIAMENTE LA MESA
        {
            Bills = DBAccessConnection.GetBills();
            this.Table = Table;
            BillOrders = new StringBuilder();
            OrdersToPayInTheSameTable = Orders.GetOrdersToPay(Table); //SE OBTIENEN LAS ORDENES PENDIENTES DE ESA MESA
        }


        public Order AddOrderToABill(int OrderID) //AGREGAR UNA ORDEN A LA FACTURA
        {
            foreach (var order in OrdersToPayInTheSameTable) //SE BUSCA LA ORDEN POR EL ID
            {
                if (order.ID == OrderID)
                {
                    BillOrders.Append(order.Product.ToString()); //SE AGREGAN LOS PRODUCTOS AL STRING
                    BillOrders.Append("\n");
                    Orders.PayOrder(order); //SE CAMBIA EL STATUS DE LA ORDEN EN LA BD
                    Cost += order.Cost; //SE ACUMULA EL COSTO
                    OrdersToPayInTheSameTable = Orders.GetOrdersToPay(Table); //SE ACTUALIZAN LAS ORDENES PENDIENTES
                    return order;
                }
            }
            return null;
        }

        public Bill CreateBill(int id, string name ) //SE RECIBE EL ID DE LA FACTURA Y EL NOMBRE DE LA MISMA
        {
            decimal Tax = Cost * CostaRicaTax; //CALCULAN LOS IMPUESTOS
            decimal FinalCost = Cost + Tax; //CALCULA EL TOTAL

            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            else
            {
                if (SearchByID(id) != null)
                {
                    return null;
                }
                else
                {
                    Bill bill = new Bill() { ID = id, Name = name, Orders= BillOrders.ToString(), Cost = Cost, Tax=Tax, FinalCost=FinalCost };
                    DBAccessConnection.CreateBill(bill); //CREA LA FACTURA EN LA BD
                    Bills = DBAccessConnection.GetBills(); //ACTUALIZA LA LISTA
                    return bill;
                }
            }
        }

        public Bill SearchByID(int id)
        {
            foreach (var bill in Bills)
            {
                if (bill.ID == id)
                {
                    return bill;
                }
            }
            return null;
        }

    }
}
