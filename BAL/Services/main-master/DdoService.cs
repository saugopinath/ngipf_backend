using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;
namespace NGIPF_BE.BAL
{
    public class DdoService : IDdoService
    {
        private readonly IDdoRepository _DdoRepository;
        private readonly IMapper _mapper;
        public DdoService(IDdoRepository DdoRepository, IMapper mapper) {
            _DdoRepository = DdoRepository;
            _mapper = mapper;
        }
        public async Task<List<DropdownStringCodeDTO>> GetDdos() 
        {
            return (List<DropdownStringCodeDTO>)await _DdoRepository.GetSelectedColumnByConditionAsync(entity => entity.DdoCode != null && entity.DdoCode!="", entity => new DropdownStringCodeDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
    }
}