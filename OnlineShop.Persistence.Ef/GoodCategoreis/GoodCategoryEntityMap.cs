using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities;
namespace OnlineShop.Persistence.EF.GoodCategoreis
{
   public class GoodCategoryEntityMap: IEntityTypeConfiguration<GoodCategory>
    {
       
        public void Configure(EntityTypeBuilder<GoodCategory> _)
        {
         _.ToTable("GoodCategories");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.Title).IsRequired();
        }
    }
}
