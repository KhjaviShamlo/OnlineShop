using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities;
namespace OnlineShop.Persistence.EF.Warehouses
{
    public class WareHouseEntityMap : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> _)
        {
            _.ToTable("WareHouse");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.GoodId).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.Inventory).IsRequired();
        }
    }
}
