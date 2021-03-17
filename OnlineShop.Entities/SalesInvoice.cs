using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Entities
{
   public class SalesInvoice
    {
        public int Id{ get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public string CustomerName { get; set; }
    }
}
