using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL
{
    public class EmpBankAccountService
    {
        private readonly IEmpBankAccountRepository _EmpBankAccountRepository;
        private readonly IMapper _mapper;
        public EmpBankAccountService(IEmpBankAccountRepository EmpBankAccountRepository, IMapper mapper) {
            _EmpBankAccountRepository = EmpBankAccountRepository;
            _mapper = mapper;
        }
        public async Task<List<EmpBankAccountDTO>> GetEmpBankAccount() 
        {
            return (List<EmpBankAccountDTO>)await _EmpBankAccountRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", entity 
            => new EmpBankAccountDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
        public async Task<List<EmpBankAccountDTO>> GetEmpBankAccount(int empId)
        {
            return (List<EmpBankAccountDTO>)await _EmpBankAccountRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode != "", entity
            => new EmpBankAccountDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
    }
}