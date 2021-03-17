using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities
namespace OnlineShop.Persistence.EF.Goods
{
    public class GoodEntityMap : IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> _)
        {
            _.ToTable("Goods");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.Title).IsRequired().HasMaxLength(50);
            _.Property(_ => _.Code).IsRequired().HasMaxLength(10);
            _.Property(_ => _.MinimumInventory).IsRequired();
            _.Property(_ => _.CategoryId).IsRequired();
            _.HasOne(_ => _.Category).WithMany(_ => _.Goods).HasForeignKey(_ => _.CategoryId).OnDelete(DeleteBehavior.Restrict);


        }
    }
}
