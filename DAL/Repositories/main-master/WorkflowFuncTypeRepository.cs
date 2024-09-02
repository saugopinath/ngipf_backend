using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
namespace ngipf_frontend.DAL
{
    public  class WorkflowFuncTypeRepository: Repository<WorkflowFunctinalityTypeMst, NgIpfDBContext>, IWorkflowFuncTypeRepository
    {
        public WorkflowFuncTypeRepository(NgIpfDBContext context) : base(context)
       {
       }
    }
}