using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities;

namespace OnlineShop.Persistence.EF.SalesInvoiceItems
{
    public class SalesInvoiceItemsEntityMap : IEntityTypeConfiguration<SalesInvoiceItem>
    {
        public void Configure(EntityTypeBuilder<SalesInvoiceItem> _)
        {
         _.ToTable("SalesInvoiceItems");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.GoodId).IsRequired();
            _.Property(_ => _.InvoiceId).IsRequired();
            _.Property(_ => _.Price).IsRequired();
        }
    }
}
