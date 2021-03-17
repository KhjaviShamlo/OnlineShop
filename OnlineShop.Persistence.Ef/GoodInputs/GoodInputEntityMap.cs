using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities;
namespace OnlineShop.Persistence.EF.GoodInputs
{
    public class GoodInputEntityMap : IEntityTypeConfiguration<GoodInput>
    {
        public void Configure(EntityTypeBuilder<GoodInput> _)
        {
            _.ToTable("GoodInputs");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.InvoiceNumber).IsRequired();
            _.Property(_ => _.GoodId).IsRequired();
            _.Property(_ => _.GoodCount).IsRequired();
           
        }
    }
}
