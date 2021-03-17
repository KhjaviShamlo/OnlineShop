using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Warehouses.Contracts
{
    public interface WareHouseRepository
    {
        void Add(Warehouse wareHouse);
        void Delete(Warehouse wareHouse);
        Task<IList<GettAllWarehouseDto>> GettAll();
        Task<GettWarehouseByIdDto> GettById(int id);
        Task<bool> IsExistById(int id);
        Task<bool> IsExistTitle(string title);
        Task<Warehouse> FindById(int id);
    }
}
