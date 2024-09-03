using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
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