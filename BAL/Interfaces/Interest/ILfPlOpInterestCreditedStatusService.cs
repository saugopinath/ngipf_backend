using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface ILfPlOpInterestCreditedStatusService
    {
         public Task<List<InterestCreditedStatusDTO>> GetList(int int_treasury_id,int int_status_code=0,int int_operator_id=0);
    }
}