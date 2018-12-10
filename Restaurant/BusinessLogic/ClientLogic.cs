﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class ClientLogic
    {
        OrderLogic orderLo;
        ProductLogic productLo;

        public ClientLogic(OrderLogic orderLo, ProductLogic productLo)
        {
            this.orderLo = orderLo;
            this.productLo = productLo;
        }



        public string AddProductToAnOrder(int orderId, Product product)
        {
            foreach (var order in OrderLogic.Orders)
            {
                if (order.ID == orderId)
                {
                    order.Products.Add(product);
                    return "Producto agregado a la orden " + orderId;
                }
            }
            return "ID de orden incorrecta";
        }
    }
}
