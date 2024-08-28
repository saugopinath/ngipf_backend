using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpBankAccountService
    {
        public Task<List<EmpBankAccountDTO>> GetEmpBankAccount(int empId);
    }
}