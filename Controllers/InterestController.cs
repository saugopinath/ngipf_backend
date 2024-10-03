
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DTOs;
using ngipf_backend.Helper;
using Microsoft.AspNetCore.Mvc;
using ngipf_backend.BAL;


namespace ngipf_backend.Controllers
{
   
    [ApiController]
    [Route("api/v1/[controller]")]
    public class InterestController : ControllerBase
    {
       
       
        private readonly ILfPlOpInterestCreditedStatusService _LfPlOpInterestCreditedStatusService;

        public InterestController(ILfPlOpInterestCreditedStatusService LfPlOpInterestCreditedStatusService)
        {
            _LfPlOpInterestCreditedStatusService = LfPlOpInterestCreditedStatusService;
        }
        [HttpPost("interestCreditedStatus")]
        public async Task<APIResponse<DynamicListResult<IEnumerable<InterestCreditedStatusDTO>>>>OpcreditedStatusList(DynamicListQueryParameters dynamicListQueryParameters)
        {
            
            APIResponse<DynamicListResult<IEnumerable<InterestCreditedStatusDTO>>> response = new();
            try
            {
                DynamicListResult<IEnumerable<InterestCreditedStatusDTO>> result = new DynamicListResult<IEnumerable<InterestCreditedStatusDTO>>
                {
                    Data = await _LfPlOpInterestCreditedStatusService.GetList(dynamicListQueryParameters),
                    DataCount = 1
                };
                response.apiResponseStatus = Enum.APIResponseStatus.Success;
                response.Message = "";
                response.result = result;
                return response;
            }
            catch (Exception Ex)
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Error;
                response.Message = Ex.Message;
                return response;
            }

        }
       
        






    }
    
  }