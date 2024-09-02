using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
namespace ngipf_frontend.DAL
{
    public class WorkflowMasterCodeRepository: Repository<WorkflowMasterCode, NgIpfDBContext>, IWorkflowMasterCodeRepository
    {
        public WorkflowMasterCodeRepository(NgIpfDBContext context) : base(context)
       {
       }
    }
}