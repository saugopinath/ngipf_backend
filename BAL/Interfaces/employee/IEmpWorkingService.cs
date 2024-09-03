using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IEmpWorkingService
    {
        public Task<List<EmpServiceDTO>> GetEmpWorking(int empId);
    }
}