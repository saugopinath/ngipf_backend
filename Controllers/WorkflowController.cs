
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DTOs;
using ngipf_backend.Helper;
using Microsoft.AspNetCore.Mvc;
using ngipf_backend.BAL;
using ngipf_backend.DAL.Entities;


namespace ngipf_backend.Controllers
{
   
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WorkflowController : ControllerBase
    {
       
       
         private readonly IWorkflowFuncTypeService _workflowFuncTypeService;
         private readonly IWorkflowOfficeTypeService _workflowOfficeTypeService;
         private readonly IWorkflowMasterCodeService _workflowMasterCodeService;
         private readonly IWorkflowUserMappingService _workflowUserMappingService;
        public WorkflowController(IWorkflowFuncTypeService WorkflowFuncTypeService,IWorkflowOfficeTypeService WorkflowOfficeTypeService, 
            IWorkflowMasterCodeService WorkflowMasterCodeService,
            IWorkflowUserMappingService WorkflowUserMappingService)
        {
            _workflowFuncTypeService = WorkflowFuncTypeService;
            _workflowOfficeTypeService = WorkflowOfficeTypeService;
            _workflowMasterCodeService = WorkflowMasterCodeService;
            _workflowUserMappingService = WorkflowUserMappingService;
        }
        [HttpGet("OfficeTypeMasterList")]
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
        [HttpGet("FuncMasterList")]
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

        [HttpGet("WorkFlowCodeMasterList")]
        public async Task<APIResponse<List<WorkFlowHierarchyListDTO>>> WorkflowMasterCodeList(int IntFuncId, int IntOfficeTypeId = 0)
        {
            APIResponse<List<WorkFlowHierarchyListDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _workflowMasterCodeService.GetList(IntFuncId, IntOfficeTypeId);
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
        [HttpGet("WorkFlowUserMapping")]
        public async Task<APIResponse<List<WorkFlowHierarchyDetailsDTO>>> WorkFlowUserMapping(int WorkFlowId)
        {
            APIResponse<List<WorkFlowHierarchyDetailsDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;
                response.result = await _workflowUserMappingService.GetList(WorkFlowId);
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