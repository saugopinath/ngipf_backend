using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IEmpBasicService
    {
        public Task<List<EmpPersonalDTO>> GetEmpBasic(int empId);
    }
}