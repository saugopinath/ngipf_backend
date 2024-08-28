using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpPayInformationService
    {
        public Task<List<EmpSalaryHeadDTO>> GetEmpPayInformation();
        public Task<List<EmpSalaryHeadDTO>> GetEmpPayInformation(int empId);
    }
}