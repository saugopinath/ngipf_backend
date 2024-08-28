using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL
{
    public class EmpOtherService
    {
        private readonly IEmpOtherRepository _EmpOtherRepository;
        private readonly IMapper _mapper;
        public EmpOtherService(IEmpOtherRepository EmpOtherRepository, IMapper mapper) {
            _EmpOtherRepository = EmpOtherRepository;
            _mapper = mapper;
        }
        public async Task<List<EmpOtherDTO>> GetEmpOther() 
        {
            return (List<EmpOtherDTO>)await _EmpOtherRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", entity 
            => new EmpOtherDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
        public async Task<List<EmpOtherDTO>> GetEmpOther(int empId)
        {
            return (List<EmpOtherDTO>)await _EmpOtherRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode != "", entity
            => new EmpOtherDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
    }
}