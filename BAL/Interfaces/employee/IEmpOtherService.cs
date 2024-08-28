using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpOtherService
    {
        public Task<List<EmpOtherDTO>> GetEmpOther(int empId);
    }
}