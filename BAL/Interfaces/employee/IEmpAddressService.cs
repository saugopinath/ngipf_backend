using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpAddressService
    {
        public Task<List<EmpAddressDTO>> GetEmpAddress(int empId);
    }
}