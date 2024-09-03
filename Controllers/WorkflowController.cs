
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DTOs;
using ngipf_backend.Helper;
using Microsoft.AspNetCore.Mvc;
using ngipf_backend.BAL;


namespace ngipf_backend.Controllers
{
   
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WorkflowController : ControllerBase
    {
       
       
        private readonly  IWorkflowFuncTypeService _workflowFuncTypeService;
         private readonly IWorkflowOfficeTypeService _workflowOfficeTypeService;

        public WorkflowController(IWorkflowFuncTypeService WorkflowFuncTypeService,IWorkflowOfficeTypeService WorkflowOfficeTypeService)
        {
            _workflowFuncTypeService = WorkflowFuncTypeService;
            _workflowOfficeTypeService = WorkflowOfficeTypeService;
        }
        [HttpGet("OfficeList")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> OfficeList()
        {
            APIResponse<List<DropdownStringCodeDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _workflowOfficeTypeService.GetList();
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
         [HttpGet("FuncList")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> FuncList()
        {
            APIResponse<List<DropdownStringCodeDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _workflowFuncTypeService.GetList();
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