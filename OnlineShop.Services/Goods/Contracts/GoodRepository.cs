using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Goods.Contracts
{
  public interface GoodRepository
    {
        void Add(RegisterGoodDto dto);
        void Delete(Good good);
        Task<IList<GetAllGoodsDto>> GetAll();
        Task<FindGoodByIdDto> FindById(int id);
    }
}
