using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IEmpOtherService
    {
        public Task<List<EmpOtherDTO>> GetEmpOther(int empId);
    }
}