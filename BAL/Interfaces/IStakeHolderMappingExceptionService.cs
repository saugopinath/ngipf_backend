using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IStakeHolderMappingExceptionService
    {
        public Task<int> GetExceptionMappingCount(int int_hoa_id);
    }
}