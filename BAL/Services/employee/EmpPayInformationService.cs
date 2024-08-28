using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL
{
    public class EmpPayInformationService
    {
        private readonly IEmpPayInformationRepository _EmpPayInformationRepository;
        private readonly IMapper _mapper;
        public EmpPayInformationService(IEmpPayInformationRepository EmpPayInformationRepository, IMapper mapper) {
            _EmpPayInformationRepository = EmpPayInformationRepository;
            _mapper = mapper;
        }
        public async Task<List<EmpSalaryDTO>> GetEmpPayInformation() 
        {
            return (List<EmpSalaryDTO>)await _EmpPayInformationRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", 
            entity => new EmpSalaryDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
        public async Task<List<EmpSalaryDTO>> GetEmpPayInformation(int empId)
        {
            return (List<EmpSalaryDTO>)await _EmpPayInformationRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode != "",
            entity => new EmpSalaryDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
    }
}