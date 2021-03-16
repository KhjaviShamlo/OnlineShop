using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Entities
{
    public class Good
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int MinimumInventory { get; set; }
        public int CategoryId { get; set; } 
        public GoodCategory Category { get; set; }
    }
}
