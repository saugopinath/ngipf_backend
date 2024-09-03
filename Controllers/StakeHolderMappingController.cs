
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DTOs;
using ngipf_backend.Helper;
using Microsoft.AspNetCore.Mvc;
using ngipf_backend.BAL;


namespace ngipf_backend.Controllers
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