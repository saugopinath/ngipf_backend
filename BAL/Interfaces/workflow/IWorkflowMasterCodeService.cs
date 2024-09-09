using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
  
        public interface IWorkflowMasterCodeService
        {
            public Task<List<WorkFlowHierarchyListDTO>> GetList(int IntFuncId,int IntOfficeTypeId=0);
        }
    
}