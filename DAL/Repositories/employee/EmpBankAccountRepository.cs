using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
namespace NGIPF_BE.DAL.Interfaces
{
    public class EmpBankAccountRepository: Repository<HrMdEmpBankAccount, NgIpfDBContext>, IEmpBankAccountRepository
    {
    }
}