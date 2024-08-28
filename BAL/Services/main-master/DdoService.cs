using AutoMapper;
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
using ngipf_frontend.DTOs;
namespace ngipf_frontend.BAL
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