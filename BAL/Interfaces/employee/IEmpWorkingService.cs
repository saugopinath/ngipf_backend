using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpWorkingService
    {
        public Task<List<EmpServiceDTO>> GetEmpWorking(int empId);
    }
}