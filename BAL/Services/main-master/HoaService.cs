using AutoMapper;
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DAL;
using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
using ngipf_frontend.DTOs;
namespace ngipf_frontend.BAL
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