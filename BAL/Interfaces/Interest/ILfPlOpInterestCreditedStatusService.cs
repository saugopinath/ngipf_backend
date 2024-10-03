using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface ILfPlOpInterestCreditedStatusService
    {
        public Task<IEnumerable<InterestCreditedStatusDTO>> GetList(DynamicListQueryParameters dynamicListQueryParameters);
    }
}