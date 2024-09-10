using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IWorkflowUserMappingService
    {
        public Task<List<WorkFlowHierarchyDetailsDTO>> GetList(int WorkFlowId);
    }
}