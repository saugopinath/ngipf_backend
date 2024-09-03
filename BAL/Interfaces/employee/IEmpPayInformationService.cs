using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IEmpPayInformationService
    {
        public Task<List<EmpSalaryHeadDTO>> GetEmpPayInformation(int empId);
    }
}