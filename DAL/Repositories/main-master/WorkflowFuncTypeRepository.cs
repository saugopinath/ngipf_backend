using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
    public  class WorkflowFuncTypeRepository: Repository<WorkflowFunctinalityTypeMst, NgIpfDBContext>, IWorkflowFuncTypeRepository
    {
        public WorkflowFuncTypeRepository(NgIpfDBContext context) : base(context)
       {
       }
    }
}