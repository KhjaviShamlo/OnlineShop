using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities;
namespace OnlineShop.Persistence.EF.SalesInvoices
{
    public class SalesInvoiceEnityMap : IEntityTypeConfiguration<SalesInvoice>
    {
        public void Configure(EntityTypeBuilder<SalesInvoice> _)
        {
            _.ToTable("SalesInvoices");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.Date).IsRequired();
            _.Property(_ => _.InvoiceNumber).IsRequired();
            _.Property(_ => _.CustomerName).IsRequired();
            _.Property(_ => _.SalesInvoiceItems).IsRequired();

        }
    }
}
