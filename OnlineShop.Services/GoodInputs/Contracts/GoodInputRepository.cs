using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.GoodInputs.Contracts
{
    public interface GoodInputRepository
    {
        void Add(GoodInput goodInput);
        void Delete(GoodInput goodInput);
        Task<IList<GettAllGoodInputDto>> GettAll();
        Task<GettGoodInputByIdDto> GettById(int id);
        Task<bool> IsExistById(int id);
        Task<GoodInput> FindById(int id);
    }
}
