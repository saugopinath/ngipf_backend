using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IHoaService
    {
        public Task<List<DropdownStringCodeDTO>> GetHoas();
    }
}