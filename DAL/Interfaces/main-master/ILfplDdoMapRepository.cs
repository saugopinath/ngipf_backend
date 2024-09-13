using ngipf_backend.DAL.Entities;
using ngipf_backend.DTOs;
namespace ngipf_backend.DAL.Interfaces
{
    public interface ILfplDdoMapRepository: IRepository<PlPfDdoHoaMap>
    {
        public Task<List<TresuryDTO>> GetTresury(int int_hoa_id);

    }

}