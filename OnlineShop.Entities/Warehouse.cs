﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Entities
{
    public class Warehouse
    {
        public int Id { get; set; }
        public int GoodID { get; set; }
        public Good Good { get; set; }
        public int Inventory { get; set; }
    }
}
