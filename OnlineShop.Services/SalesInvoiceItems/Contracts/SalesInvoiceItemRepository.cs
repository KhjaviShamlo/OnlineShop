using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.SalesInvoiceItems.Contracts
{
    public interface SalesInvoiceItemRepository
    {
        void Add(SalesInvoiceItem salesInvoiceItem);
        void Delete(SalesInvoiceItem salesInvoiceItem);
        Task<IList<GettAllSalesInvoiceItemDto>> GettAll();
        Task<GettSalesInvoiceItemByIdDto> GettById(int id);
        Task<bool> IsExistById(int id);
        Task<bool> IsExistTitle(string title);
        Task<SalesInvoice> FindById(int id);
    }
}
