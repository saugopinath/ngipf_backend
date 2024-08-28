using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL
{
    public class EmpBasicService
    {
        private readonly IEmpBasicRepository _EmpBasicRepository;
        private readonly IMapper _mapper;
        public EmpBasicService(IEmpBasicRepository EmpBasicRepository, IMapper mapper) {
            _EmpBasicRepository = EmpBasicRepository;
            _mapper = mapper;
        }
        public async Task<List<EmpPersonalDTO>> GetEmpBasic() 
        {
            return (List<EmpPersonalDTO>)await _EmpBasicRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", entity 
            => new EmpPersonalDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
        public async Task<List<EmpPersonalDTO>> GetEmpBasic(int empId)
        {
            return (List<EmpPersonalDTO>)await _EmpBasicRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode != "", entity
            => new EmpPersonalDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }

    }
}