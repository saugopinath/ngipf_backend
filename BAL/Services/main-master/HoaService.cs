using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;
namespace NGIPF_BE.BAL
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
                Name = entity.Hoa,
                Code = entity.IntDeptHoaId.ToString()
            });
            
        }
    }
}