using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IDdoService
    {
        public Task<List<DropdownStringCodeDTO>> GetDdos();
    }
}