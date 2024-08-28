using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpPayInformationService
    {
        public Task<List<EmpSalaryHeadDTO>> GetEmpPayInformation(int empId);
    }
}