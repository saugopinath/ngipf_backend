
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DTOs;
using ngipf_backend.Helper;
using Microsoft.AspNetCore.Mvc;
using ngipf_backend.BAL;


namespace ngipf_backend.Controllers
{
   
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmployeeController : ControllerBase
    {
       
       
        private readonly IEmpPfBasicService _empPfBasicService;

        public EmployeeController(IEmpPfBasicService empPfBasicService)
        {
            _empPfBasicService = empPfBasicService;
        }
        [HttpPatch("empList")]
        public async Task<APIResponse<DynamicListResult<IEnumerable<EmpListViewDTO>>>> ListOfEmployees(string tresuary_code, int op_code, int salary_source, DynamicListQueryParameters dynamicListQueryParameters)
        {
            APIResponse<DynamicListResult<IEnumerable<EmpListViewDTO>>> response = new();
            try
            {
                DynamicListResult<IEnumerable<EmpListViewDTO>> result = new DynamicListResult<IEnumerable<EmpListViewDTO>>
                {
                    Headers = new List<ListHeader>
                    {

                     new ListHeader
                     {
                        Name="PF Account No.",
                        DataType="text",
                        FieldName ="PFAccountNumber",
                        FilterField ="PfAacountNo",
                        IsFilterable=false,
                        IsSortable=false,
                     },
                    new ListHeader
                    {
                        Name="Employee Name (Id)",
                        DataType="text",
                        FieldName ="NameWithEmpid",
                        FilterField ="EmpId",
                        IsFilterable=true,
                        IsSortable=false,
                    },
                    new ListHeader
                    {
                        Name="Date of Joining",
                        DataType="DateOnly",
                        FieldName ="Doj",
                        FilterField ="DateOfJoining",
                        IsFilterable=true,
                        IsSortable=false,
                    },
                    new ListHeader
                    {
                        Name="Status",
                        DataType="text",
                        FieldName ="Status",
                        FilterField ="StatusNavigation.int_master_id",
                        IsFilterable=false,
                        IsSortable=false,
                    }
                    },
                    Data = await _empPfBasicService.GetEmpList(tresuary_code,op_code,salary_source,dynamicListQueryParameters),
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