
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
        [HttpGet("interestCreditedStatus")]
        public async Task<APIResponse<DynamicListResult<IEnumerable<InterestCreditedStatusDTO>>>> ListOfInterestCreditedStatus(int int_treasury_id, int int_status_code = 0, int int_operator_id = 0)
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
                    Data = await _LfPlOpInterestCreditedStatusService.GetList(dynamicListQueryParametersCommon),
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