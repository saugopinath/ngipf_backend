using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IWorkflowFuncTypeService
    {
        public Task<List<DropdownStringCodeDTO>> GetList(); 
    }
}