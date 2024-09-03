using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
    public class WorkflowMasterCodeRepository: Repository<WorkflowMasterCode, NgIpfDBContext>, IWorkflowMasterCodeRepository
    {
        public WorkflowMasterCodeRepository(NgIpfDBContext context) : base(context)
       {
       }
    }
}