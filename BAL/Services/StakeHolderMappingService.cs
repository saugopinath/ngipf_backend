using AutoMapper;
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DAL;
using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL
{
    public class StakeHolderMappingService : IStakeHolderMappingService
    {
        private readonly IStakeHolderMappingRepository _StakeHolderMappingRepository;
        private readonly IMapper _mapper;
        public StakeHolderMappingService(IStakeHolderMappingRepository StakeHolderMappingRepository, IMapper mapper)
        {
            _StakeHolderMappingRepository = StakeHolderMappingRepository;
            _mapper = mapper;
        }
        public async Task<List<StakeHolderMappingListViewDTO>> GetMappingList()
        {
            return (List<StakeHolderMappingListViewDTO>)await _StakeHolderMappingRepository.GetSelectedColumnAsync( entity => new StakeHolderMappingListViewDTO
            {
                HOA = entity.IntHoa.Hoa,
                SanctionAdminCount = entity.SancAuthCountNavigation.Name,
                SanctionAdminNature = entity.SanctionAuthNatureNavigation.Name,
                RecomandingAuthRequired = entity.RecoAuthRequired == true ? "YES" : "NO",
                RecomandingAuthCount = entity.RecomAuthCountNavigation.Name,
                RecomandingAuthNature = entity.RecoAuthNatureNavigation.Name,
                
            });
        }
    }
}