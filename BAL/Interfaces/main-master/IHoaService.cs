using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IHoaService
    {
        public Task<List<DropdownStringCodeDTO>> GetHoas();
    }
}