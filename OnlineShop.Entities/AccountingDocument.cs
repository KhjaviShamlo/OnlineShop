using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Entities
{
     public class AccountingDocument
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DocumentId { get; set; }
        public string SalesInvoiceNumber { get; set; }
        public int SalesInvoiceId { get; set; }
        public SalesInvoice SalesInvoice { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
