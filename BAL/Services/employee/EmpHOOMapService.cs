using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL
{
    public class EmpHOOMapService
    {
        private readonly IEmpHOOMapRepository _EmpHOOMapRepository;
        private readonly IMapper _mapper;
        public EmpHOOMapService(IEmpHOOMapRepository EmpHOOMapRepository, IMapper mapper) {
            _EmpHOOMapRepository = EmpHOOMapRepository;
            _mapper = mapper;
        }
        public async Task<List<EmpOfficeDTO>> GetEmpHOOMap() 
        {
            return (List<EmpOfficeDTO>)await _EmpHOOMapRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", entity 
            => new EmpOfficeDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
        public async Task<List<EmpOfficeDTO>> GetEmpHOOMap(int empId)
        {
            return (List<EmpOfficeDTO>)await _EmpHOOMapRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode != "", entity
            => new EmpOfficeDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
    }
}