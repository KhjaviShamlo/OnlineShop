using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.AccountingDocuments.Contracts
{
    public interface AccountingDocumentsRepository
    {
        void Add(AccountingDocument accountingDocument );
        void Delete(AccountingDocument accountingDocument);
        Task<IList<GettAllAccountingDocumentDto>> GettAll();
        Task<GettAccountingDocumentByIdDto> GettById(int id);
        Task<GoodCategory> FindById(int id);
    }
}
