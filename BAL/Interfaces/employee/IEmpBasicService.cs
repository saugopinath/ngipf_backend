using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpBasicService
    {
        public Task<List<EmpPersonalDTO>> GetEmpBasic(int empId);
    }
}