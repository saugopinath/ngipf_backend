using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpOtherService
    {
        public Task<List<EmpOtherDTO>> GetEmpOther();
        public Task<List<EmpOtherDTO>> GetEmpOther(int empId);
    }
}