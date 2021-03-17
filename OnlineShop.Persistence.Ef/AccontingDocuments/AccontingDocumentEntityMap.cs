using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities;
namespace OnlineShop.Persistence.EF.AccontingDocuments
{
    class AccontingDocumentEntityMap : IEntityTypeConfiguration<AccountingDocument>
    {
        public void Configure(EntityTypeBuilder<AccountingDocument> _)
        {
            _.ToTable("AccountingDocuments");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.Date).IsRequired();
            _.Property(_ => _.DocumentNumber).IsRequired();
            _.Property(_ => _.SalesInvoiceId).IsRequired();
        }
    }
}
