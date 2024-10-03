using AutoMapper;
using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;

namespace ngipf_backend.BAL
{
    public class LfPlOpInterestCreditedStatusService :ILfPlOpInterestCreditedStatusService
    {
        private readonly ILfPlOpInterestCreditedStatusRepository _LfPlOpInterestCreditedStatusRepository;
        private readonly IMapper _mapper;
        public LfPlOpInterestCreditedStatusService(ILfPlOpInterestCreditedStatusRepository LfPlOpInterestCreditedStatusRepository, IMapper mapper)
        {
            _LfPlOpInterestCreditedStatusRepository = LfPlOpInterestCreditedStatusRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InterestCreditedStatusDTO>> GetList(DynamicListQueryParameters dynamicListQueryParameters)
        {
            return await _LfPlOpInterestCreditedStatusRepository.GetSelectedColumnByConditionAsync(entity => true, entity => new InterestCreditedStatusDTO
            {
               Id=entity.Id
            }, dynamicListQueryParameters);
        }
    }
}