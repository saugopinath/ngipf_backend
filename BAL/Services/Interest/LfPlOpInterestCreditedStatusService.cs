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
   
        public async Task<List<InterestCreditedStatusDTO>> GetList(int int_treasury_id,int int_status_code=0,int int_operator_id=0)
        {

            DynamicListQueryParametersCommon dynamicListQueryParametersCommon = new DynamicListQueryParametersCommon();
            dynamicListQueryParametersCommon.filterParameters = new List<FilterParameter>();
            dynamicListQueryParametersCommon.sortParameters = new List<SortParameter>();
          
            FilterParameter filterParameter = new FilterParameter
            {
                    Field = "IntTreasuryId",
                    Value = int_treasury_id.ToString(),
                    Operator = "equals"
            };
            dynamicListQueryParametersCommon.filterParameters.Add(filterParameter);
            
            SortParameter sortParameter1 = new SortParameter
            {
                Field = "IntHoaId",
                Order = "ASC"
            };
            dynamicListQueryParametersCommon.sortParameters.Add(sortParameter1);
        
            return (List<InterestCreditedStatusDTO>) await _LfPlOpInterestCreditedStatusRepository.getallCommon(dynamicListQueryParametersCommon, entity => new InterestCreditedStatusDTO
            {
                Id = entity.Id,
               
            });
            
        }
    }
}