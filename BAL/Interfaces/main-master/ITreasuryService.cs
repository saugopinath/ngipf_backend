using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface ITreasuryService
    {
        public Task<List<DropdownStringCodeDTO>> GetTreasurys();
    }
}