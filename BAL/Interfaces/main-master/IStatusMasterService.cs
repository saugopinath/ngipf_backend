using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IStatusMasterService
    {
        public Task<List<DropdownStringCodeDTO>> GetList();
    }
}