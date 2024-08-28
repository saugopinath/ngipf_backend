using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpBankAccountService
    {
        public Task<List<EmpBankAccountDTO>> GetEmpBankAccount();
        public Task<List<EmpBankAccountDTO>> GetEmpBankAccount(int empId);
    }
}