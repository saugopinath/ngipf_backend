using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IWorkflowOfficeTypeService
    {
         public Task<List<DropdownStringCodeDTO>> GetList();
    }
}