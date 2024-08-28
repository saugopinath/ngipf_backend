using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpSalaryHeadService
    {
        public Task<List<EmpSalaryHeadDTO>> GetEmpSalaryHead();
        public Task<List<EmpSalaryHeadDTO>> GetEmpSalaryHead(int empId);
    }
}