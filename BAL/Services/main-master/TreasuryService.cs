using AutoMapper;
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
using ngipf_frontend.DTOs;
namespace ngipf_frontend.BAL
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