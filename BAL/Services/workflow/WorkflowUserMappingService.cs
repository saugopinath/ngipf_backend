using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;

namespace ngipf_backend.BAL
{
    public class WorkflowUserMappingService:IWorkflowUserMappingService
    {
        
        private readonly IWorkflowUserMappingRepository _WorkflowUserMappingRepository;
        private readonly IMapper _mapper;
        public WorkflowUserMappingService(IWorkflowUserMappingRepository WorkflowUserMappingRepository, IMapper mapper) {
            _WorkflowUserMappingRepository = WorkflowUserMappingRepository;
            _mapper = mapper;
        }

        public async Task<List<WorkFlowHierarchyDetailsDTO>>GetList(int WorkFlowId)
        {
            DynamicListQueryParametersCommon dynamicListQueryParametersCommon = new DynamicListQueryParametersCommon();
            dynamicListQueryParametersCommon.filterParameters = new List<FilterParameter>();
            dynamicListQueryParametersCommon.sortParameters = new List<SortParameter>();
            FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntWorkflowId",
                    Value = WorkFlowId.ToString(),
                    Operator = "equals"
                };
            dynamicListQueryParametersCommon.filterParameters.Add(filterParameter);

            SortParameter sortParameter1 = new SortParameter
            {
                Field = "IntRoleId",
                Order = "ASC"
            };
            dynamicListQueryParametersCommon.sortParameters.Add(sortParameter1);

           

            return (List<WorkFlowHierarchyDetailsDTO>)await _WorkflowUserMappingRepository.getallCommon(dynamicListQueryParametersCommon, entity => new WorkFlowHierarchyDetailsDTO
            {
                IntMmWorkflowUserMapping=entity.IntMmWorkflowUserMapping,
                Role = entity.IntRole.RoleDesc,
                Name = entity.IntUser.UserName,
                
            });
        }
    }
}