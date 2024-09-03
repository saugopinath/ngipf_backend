using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IEmpBankAccountService
    {
        public Task<List<EmpBankAccountDTO>> GetEmpBankAccount(int empId);
    }
}