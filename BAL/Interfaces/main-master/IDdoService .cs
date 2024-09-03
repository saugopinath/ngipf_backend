using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IDdoService
    {
        public Task<List<DropdownStringCodeDTO>> GetDdos();
    }
}