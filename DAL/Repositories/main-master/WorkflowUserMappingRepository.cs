using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
namespace ngipf_frontend.DAL
{
    public class WorkflowUserMappingRepository: Repository<WorkflowUserMapping, NgIpfDBContext>, IWorkflowUserMappingRepository
    {
      public WorkflowUserMappingRepository(NgIpfDBContext context) : base(context)
       {
       }
    }
}