using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface ILfplopService
    {
        public Task<List<DropdownStringCodeDTO>> GetLfplops();
    }
}