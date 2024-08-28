using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IHoaService
    {
        public Task<List<DropdownStringCodeDTO>> GetHoas();
    }
}