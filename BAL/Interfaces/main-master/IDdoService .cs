using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IDdoService
    {
        public Task<List<DropdownStringCodeDTO>> GetDdos();
    }
}