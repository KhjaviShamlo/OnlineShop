using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Entities
{
   public class SalesInvoiceItems
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public int FactorId { get; set; }
    }
}
