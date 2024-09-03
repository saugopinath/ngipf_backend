using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IEmpAddressService
    {
        public Task<List<EmpAddressDTO>> GetEmpAddress(int empId);
    }
}