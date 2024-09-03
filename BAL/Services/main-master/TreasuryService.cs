using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
{
    public class TreasuryService : ITreasuryService
    {
        private readonly ITreasuryRepository _TreasuryRepository;
        private readonly IMapper _mapper;
        public TreasuryService(ITreasuryRepository TreasuryRepository, IMapper mapper) {
            _TreasuryRepository = TreasuryRepository;
            _mapper = mapper;
        }
        public async Task<List<DropdownStringCodeDTO>> GetTreasurys() 
        {
            return (List<DropdownStringCodeDTO>)await _TreasuryRepository.GetSelectedColumnByConditionAsync(entity => entity.IntTreasuryCode != null && entity.IntTreasuryCode!="", entity => new DropdownStringCodeDTO
            {
                Name = entity.TreasuryName,
                Code = entity.IntTreasuryCode,
            });
        }
    }
}