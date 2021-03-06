using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
namespace OnlineShop.Migrations
{
    
    [Migration(202103161421)]
    
   public class _202103161421_SchemaInitialized : FluentMigrator.Migration
    {
        public override void Up()
        {
           

            Create.Table("GoodCategories")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Title").AsString().NotNullable();

            Create.Table("Goods")
               .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("Title").AsString().NotNullable()
               .WithColumn("Code").AsString().NotNullable()
               .WithColumn("MinimumInventory").AsInt32().NotNullable()
               .WithColumn("CategoryId").AsInt32().ForeignKey("FK_Goods_GoodCategories", "GoodCategories", "Id");

            Create.Table("SalesInvoiceis")
               .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("Date").AsDateTime().NotNullable()
               .WithColumn("InvoiceNumber").AsString().NotNullable()
               .WithColumn("CustomerName").AsString().NotNullable();

            Create.Table("AccountingDocuments")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Date").AsDateTime()
                .WithColumn("DocumentNumber").AsInt32().NotNullable()
                .WithColumn("SalesInvoiceNumber").AsString().NotNullable()
                .WithColumn("SalesInvoiceId").AsInt32().ForeignKey("FK_AccountingDocuments_SalesInvoiceis", "SalesInvoiceis", "Id")
                .WithColumn("TotalAmount").AsDecimal().NotNullable();

            Create.Table("GoodInputs")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("InvoiceNumber").AsString().NotNullable()
                .WithColumn("GoodId").AsInt32().ForeignKey("Goods", "Id")
                .WithColumn("EntryDate").AsDateTime().NotNullable()
                .WithColumn("GoodCount").AsInt32().NotNullable();

            Create.Table("SalesInvoiceItems")
                 .WithColumn("Id").AsInt32().Identity().NotNullable()
                 .WithColumn("GoodId").AsInt32().ForeignKey("Goods", "Id")
                 .WithColumn("Count").AsInt32().NotNullable()
                 .WithColumn("Price").AsDecimal().NotNullable()
                 .WithColumn("InvoiceId").AsInt32().ForeignKey("FK_SalesInvoiceItems_SalesInvoiceis", "SalesInvoiceis", "Id");

            Create.Table("Warehouses")
                .WithColumn("Id").AsInt32().Identity().NotNullable()
                .WithColumn("GoodId").AsInt32().ForeignKey("FK_Warehouses_Goods", "Goods", "Id")
                .WithColumn("Inventory").AsInt32();

        }
        public override void Down()
        {
            throw new NotImplementedException();
        }

    }
}
