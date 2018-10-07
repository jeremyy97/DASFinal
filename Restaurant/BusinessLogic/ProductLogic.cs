using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace BusinessLogic
{
    public static class ProductLogic
    {
        public static string PrintResume(Product product)
        {
            return product.Name + " ₡" + product.Cost;
        }

        public static string PrintDetail(Product product)
        {
            return product.Name + ":\n" + "\nDescripción: " + product.Description + "\nCalorías: " + product.Calories + "\nCosto: ₡" + product.Cost;
        }
    }
}
