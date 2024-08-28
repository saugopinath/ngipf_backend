
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DTOs;
using ngipf_frontend.Helper;
using Microsoft.AspNetCore.Mvc;


namespace ngipf_frontend.Controllers
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
            
        }
       
       
       
       
       
        
       

    }
    
  }