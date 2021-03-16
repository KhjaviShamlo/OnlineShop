﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
namespace OnlineShop.Migrations
{[Migration(202103161421)]
    
    class _202103161421_SchemaInitialized : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("Goods")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Title").AsString().NotNullable()
                .WithColumn("Code").AsString().NotNullable()
                .WithColumn("MinimumInventory").AsInt32().NotNullable()
                .WithColumn("CategoryId").AsInt32().ForeignKey("GoodCategories","Id");

            Create.Table("GoodCategories")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Title").AsString().NotNullable();

            Create.Table("SalesInvoice")
               .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("Date").AsDateTime().NotNullable()
               .WithColumn("InvoiceNumber").AsString().NotNullable()
               .WithColumn("CustomerName").AsString().NotNullable()
               .WithColumn("AccountingDocuments").AsString().NotNullable();

            Create.Table("AccountingDocuments")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Date").AsDateTime()
                .WithColumn("DocumentNumber").AsInt32().NotNullable()
                .WithColumn("SalesInvoiceNumber").AsString().NotNullable()
                .WithColumn("SalesInvoiceId").AsInt32().ForeignKey("SalesInvoice", "Id")
                .WithColumn("TotalAmount").AsDecimal().NotNullable();

            Create.Table("GoodInputs")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("InvoiceNumber").AsString().NotNullable()
                .WithColumn("GoodId").AsInt32().ForeignKey("Goods", "Id")
                .WithColumn("EntryDate").AsDateTime().NotNullable()
                .WithColumn("Numberofgoods").AsInt32().NotNullable();

           

        }
        public override void Down()
        {
            throw new NotImplementedException();
        }

    }
}