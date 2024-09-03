using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
using System.ComponentModel.Design;

namespace ngipf_backend.BAL
{
    public class StakeHolderMappingService : IStakeHolderMappingService
    {
        private readonly IStakeHolderMappingRepository _StakeHolderMappingRepository;
        private readonly IStakeHolderMappingExceptionService _StakeHolderMappingExceptionService;
        private readonly IMapper _mapper;
        public StakeHolderMappingService(IStakeHolderMappingRepository StakeHolderMappingRepository, IStakeHolderMappingExceptionService StakeHolderMappingExceptionService, IMapper mapper)
        {
            _StakeHolderMappingRepository = StakeHolderMappingRepository;
            _StakeHolderMappingExceptionService = StakeHolderMappingExceptionService;
            _mapper = mapper;
        }
        public async Task<List<StakeHolderMappingListViewDTO>> GetMappingList()
        {
            return (List<StakeHolderMappingListViewDTO>)await _StakeHolderMappingRepository.GetSelectedColumnByConditionWithSortAsync(entity =>true, entity => new StakeHolderMappingListViewDTO
            {
                HOA = entity.IntHoa.Hoa,
                SanctionAdminCount = entity.SancAuthCountNavigation.Name,
                SanctionAdminNature = entity.SanctionAuthNatureNavigation.Name,
                RecomandingAuthRequired = entity.RecoAuthRequired == true ? "YES" : "NO",
                RecomandingAuthCount = entity.RecomAuthCountNavigation.Name,
                RecomandingAuthNature = entity.RecoAuthNatureNavigation.Name,
                ExceptionCount = _StakeHolderMappingExceptionService.GetExceptionMappingCount(entity.IntHoaId)
            }, "IntHoaId", "ASC");
        }

    }
}