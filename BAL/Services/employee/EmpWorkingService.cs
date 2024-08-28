using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL
{
    public interface EmpWorkingService
    {
        private readonly IEmpWorkingRepository _EmpWorkingRepository;
        private readonly IMapper _mapper;
        public EmpWorkingService(IEmpWorkingRepository EmpWorkingRepository, IMapper mapper) {
            _EmpWorkingRepository = EmpWorkingRepository;
            _mapper = mapper;
        }
        public async Task<List<EmpServiceDTO>> GetEmpWorking() 
        {
            return (List<EmpServiceDTO>)await _EmpWorkingRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", entity 
            => new EmpServiceDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
        public async Task<List<EmpServiceDTO>> GetEmpWorking(int empId)
        {
            return (List<EmpServiceDTO>)await _EmpWorkingRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode != "", entity
            => new EmpServiceDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
    }
}