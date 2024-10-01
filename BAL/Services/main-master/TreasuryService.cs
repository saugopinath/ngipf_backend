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
        public async Task<List<TresuryDTO>> GetTreasurys() 
        {
            return (List<TresuryDTO>)await _TreasuryRepository.GetSelectedColumnByConditionAsync(entity => entity.IntTreasuryCode != null && entity.IntTreasuryCode!="", entity => new TresuryDTO
            {
                IntTreasuryId= entity.IntTreasuryId,
                Name = entity.TreasuryName,
                Code = entity.TreasuryCode,
                TreasuryCode = entity.TreasuryCode,
                TreasuryName = entity.TreasuryName,
                DistrictCode = entity.DistrictCode,
                TreasurySrlNumber = entity.TreasurySrlNumber,
                OfficerName = entity.OfficerName,

            });
        }
    }
}