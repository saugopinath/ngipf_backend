using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL
{
    public class EmpSalaryHeadService
    {
         private readonly IEmpSalaryHeadRepository _EmpSalaryHeadRepository;
        private readonly IMapper _mapper;
        public EmpSalaryHeadService(IEmpSalaryHeadRepository EmpSalaryHeadRepository, IMapper mapper) {
            _EmpSalaryHeadRepository = EmpSalaryHeadRepository;
            _mapper = mapper;
        }
        public async Task<List<EmpSalaryHeadDTO>> GetDdos() 
        {
            return (List<EmpSalaryHeadDTO>)await _EmpSalaryHeadRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", entity 
            => new EmpSalaryHeadDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
        public async Task<List<EmpSalaryHeadDTO>> GetDdos(int empId)
        {
            return (List<EmpSalaryHeadDTO>)await _EmpSalaryHeadRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode != "", entity
            => new EmpSalaryHeadDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
    }
}