using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL
{
    public class EmpAddressService
    {
         private readonly IEmpAddressRepository _EmpAddressRepository;
         private readonly IMapper _mapper;
         public EmpAddressService(IEmpAddressRepository EmpAddressRepository, IMapper mapper) {
            _EmpAddressRepository = EmpAddressRepository;
            _mapper = mapper;
         }
        public async Task<List<EmpAddressDTO>> GetEmpAddress() 
        {
            return (List<EmpAddressDTO>) await _EmpAddressRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", entity => new EmpAddressDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
        public async Task<List<EmpAddressDTO>> GetEmpAddress(int empId)
        {
            return (List<EmpAddressDTO>)await _EmpAddressRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode != "", entity => new EmpAddressDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
    }
}