using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IEmpSalaryHeadService
    {
        public Task<List<EmpSalaryHeadDTO>> GetEmpSalaryHead(int empId);
    }
}