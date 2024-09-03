using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
    public class WorkflowUserMappingRepository: Repository<WorkflowUserMapping, NgIpfDBContext>, IWorkflowUserMappingRepository
    {
      public WorkflowUserMappingRepository(NgIpfDBContext context) : base(context)
       {
       }
    }
}