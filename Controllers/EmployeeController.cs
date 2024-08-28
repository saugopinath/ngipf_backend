
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DTOs;
using NGIPF_BE.Helper;
using Microsoft.AspNetCore.Mvc;


namespace NGIPF_BE.Controllers
{
   
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpBasicService _empBasicService;
        private readonly IEmpWorkingService _empWorkingService;
        private readonly IEmpAddressService _empAddressService;
        private readonly IEmpSalaryHeadService _empSalaryHeadService;
        private readonly IEmpPayInformationService _empPayInformationService;
        private readonly IEmpHOOMapService _empHOOMapService;
        private readonly IEmpOtherService _empOtherService;
       
        public EmployeeController()
        {
            _empBasicService = empBasicService;
            _empWorkingService = empWorkingService;
            _empAddressService = empAddressService;
            _empSalaryHeadService = empSalaryHeadService;
            _empPayInformationService = empPayInformationService;
            _empHOOMapService = empHOOMapService;
            _empOtherService = empOtherService;
        }
        [HttpGet("getEmpList/{salary_source}")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> getEmployees(string salary_source)
        {

            APIResponse<List<EmpDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _treasuryService.GetTreasurys();
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