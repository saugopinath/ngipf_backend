using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpAddressService
    {
        public Task<List<EmpAddressDTO>> GetEmpAddress();
        public Task<List<EmpAddressDTO>> GetEmpAddress(int empId);
    }
}