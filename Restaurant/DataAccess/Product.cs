﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public decimal Cost { get; set; }
        public int Calories { get; set; }

    }
}
