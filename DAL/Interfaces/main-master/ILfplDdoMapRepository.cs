using ngipf_backend.DAL.Entities;
using ngipf_backend.DTOs;
namespace ngipf_backend.DAL.Interfaces
{
    public interface ILfplDdoMapRepository: IRepository<PlPfDdoHoaMap>
    {
        public List<TresuryDTO> GetTresury(int int_hoa_id);
        public List<PfdAdminDTO> GetPfdAdmin(int int_treasury_id, int int_hoa_id);

    }

}