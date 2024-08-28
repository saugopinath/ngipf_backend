using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;
namespace NGIPF_BE.BAL
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