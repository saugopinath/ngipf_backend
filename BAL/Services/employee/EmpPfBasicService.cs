using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL
{
    public class EmpPfBasicService
    {
         private readonly IEmpPfBasicRepository _EmpPfBasicRepository;
         private readonly IMapper _mapper;
         public EmpPfBasicService(IEmpPfBasicRepository EmpPfBasicRepository, IMapper mapper) {
            _EmpPfBasicRepository = EmpPfBasicRepository;
            _mapper = mapper;
         }
        public async Task<List<EmpListViewDTO>> GetEmpList() 
        {
            return (List<EmpListViewDTO>) await _EmpPfBasicRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", entity => new EmpListViewDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
       
    }
}