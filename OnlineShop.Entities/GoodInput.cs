using System;
namespace OnlineShop.Entities
{
    public class GoodInput
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public int GoodId { get; set; }
        public Good Good { get; set; }
        public DateTime EntryDate { get; set; }
        public int GoodCount { get; set; }
    }
}
