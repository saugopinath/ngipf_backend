using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpWorkingService
    {
        public Task<List<EmpServiceDTO>> GetEmpWorking();
        public Task<List<EmpServiceDTO>> GetEmpWorking(int empId);
    }
}