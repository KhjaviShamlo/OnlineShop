using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Entities
{
   public class SalesInvoiceItem
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public Good Good { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public int InvoiceId { get; set; }
        public SalesInvoice SalesInvoice { get; set; }
    }
}
