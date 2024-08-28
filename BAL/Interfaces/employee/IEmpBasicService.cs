using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpBasicService
    {
        public Task<List<EmpPersonalDTO>> GetEmpBasic();
        public Task<List<EmpPersonalDTO>> GetEmpBasic(int empId);
    }
}