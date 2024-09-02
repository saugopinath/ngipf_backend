
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DTOs;
using ngipf_frontend.Helper;
using Microsoft.AspNetCore.Mvc;
using ngipf_frontend.BAL;


namespace ngipf_frontend.Controllers
{
   
    [ApiController]
    [Route("api/v1/[controller]")]
    public class StakeHolderMappingController : ControllerBase
    {
       
       
        private readonly IStakeHolderMappingService _stakeHolderMappingService;

        public StakeHolderMappingController(IStakeHolderMappingService StakeHolderMappingService)
        {
            _stakeHolderMappingService = StakeHolderMappingService;
        }
        [HttpGet("list")]
        public async Task<APIResponse<List<StakeHolderMappingListViewDTO>>> StakeHolderMapping()
        {
            APIResponse<List<StakeHolderMappingListViewDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _stakeHolderMappingService.GetMappingList();
                response.Message = "";
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