using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpSalaryHeadService
    {
        public Task<List<EmpSalaryHeadDTO>> GetEmpSalaryHead(int empId);
    }
}