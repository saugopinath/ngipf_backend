using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface ILfplopService
    {
        public Task<List<DropdownStringCodeDTO>> GetLfplops();
    }
}