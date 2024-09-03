using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
{
    public class HoaService : IHoaService
    {
        private readonly IHoaRepository _HoaRepository;
        private readonly IMapper _mapper;
        public HoaService(IHoaRepository HoaRepository, IMapper mapper) {
            _HoaRepository = HoaRepository;
            _mapper = mapper;
        }
        public async Task<List<DropdownStringCodeDTO>> GetHoas() 
        {
            return (List<DropdownStringCodeDTO>)await _HoaRepository.GetSelectedColumnAsync(entity => new DropdownStringCodeDTO
            {
                Name = entity.Hoa + "(" + entity.IntScheme.Description+")",
                Code = entity.IntHoaId.ToString()
            });
            
        }
    }
}