using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface ITreasuryService
    {
        public Task<List<TresuryDTO>> GetTreasurys();
    }
}