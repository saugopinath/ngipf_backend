using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
    public class WorkflowOfficeTypeFuncMappingRepository: Repository<WorkflowOfficeTypeFuncMapping, NgIpfDBContext>, IWorkflowOfficeTypeFuncMappingRepository
    {
        public WorkflowOfficeTypeFuncMappingRepository(NgIpfDBContext context) : base(context)
       {
       }
    }
}