using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface ITreasuryService
    {
        public Task<List<DropdownStringCodeDTO>> GetTreasurys();
    }
}