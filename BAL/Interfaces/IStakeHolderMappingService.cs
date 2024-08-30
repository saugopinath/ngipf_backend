using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IStakeHolderMappingService
    {
        public Task<List<StakeHolderMappingListViewDTO>> GetMappingList();
    }
}