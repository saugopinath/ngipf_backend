using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
{
    public class WorkflowMasterCodeService:IWorkflowMasterCodeService
    {
        
        private readonly IWorkflowMasterCodeRepository _WorkflowMasterCodeRepository;
        private readonly IMapper _mapper;
        public WorkflowMasterCodeService(IWorkflowMasterCodeRepository WorkflowMasterCodeRepository, IMapper mapper) {
            _WorkflowMasterCodeRepository = WorkflowMasterCodeRepository;
            _mapper = mapper;
        }
        public async Task<List<WorkFlowHierarchyListDTO>> GetList(int IntFuncId, int IntOfficeTypeId = 0)
        {
            DynamicListQueryParametersCommon dynamicListQueryParametersCommon = new DynamicListQueryParametersCommon();
            dynamicListQueryParametersCommon.filterParameters = new List<FilterParameter>();
            dynamicListQueryParametersCommon.sortParameters = new List<SortParameter>();
            if (IntFuncId > 0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntFuncId",
                    Value = IntFuncId.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParametersCommon.filterParameters.Add(filterParameter);

            }

            if (IntOfficeTypeId > 0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntOfficeTypeId",
                    Value = IntOfficeTypeId.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParametersCommon.filterParameters.Add(filterParameter);
            }
            SortParameter sortParameter1 = new SortParameter
            {
                Field = "IntHoaId",
                Order = "ASC"
            };
            dynamicListQueryParametersCommon.sortParameters.Add(sortParameter1);

            SortParameter sortParameter2 = new SortParameter
            {
                Field = "IntTreasuryId",
                Order = "ASC"
            };
            dynamicListQueryParametersCommon.sortParameters.Add(sortParameter2);

            return (List<WorkFlowHierarchyListDTO>)await _WorkflowMasterCodeRepository.getallCommon(dynamicListQueryParametersCommon, entity => new WorkFlowHierarchyListDTO
            {
                IntMmWorkflowStatusCode = entity.IntMmWorkflowStatusCode,
                HOA = entity.IntHoa.Hoa + " ( " + entity.IntHoa.IntScheme.Description + " )",
                Functionality = entity.IntFunc.Name,
                Office = entity.IntOfficeType.Name,
                Treasury = entity.IntTreasury.TreasuryName+ " ( " + entity.IntTreasury.TreasuryCode + " )",
                NgipfAdmin = entity.IntOperator.OperatorName + " ( " + entity.IntOperator.OperatorId + " )",
            });
        }

    }
}