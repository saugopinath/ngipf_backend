using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface ILfplopService
    {
        public Task<List<DropdownStringCodeDTO>> GetLfplops();
    }
}