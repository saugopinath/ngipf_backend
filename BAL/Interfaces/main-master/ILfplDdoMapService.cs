using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface ILfplDdoMapService
    {
        public Task<List<OperatorListCommonDTO>> GetList(int int_hoa_id=0,int int_treasury_id=0,int int_ddo_id=0,int int_operator_id=0);
        public Task<List<TresuryDTO>> GetTresuries(int int_hoa_id);
    }
}