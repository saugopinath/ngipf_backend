using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
namespace ngipf_frontend.DAL
{
    public class WorkflowOfficeTypeFuncMappingRepository: Repository<WorkflowOfficeTypeFuncMapping, NgIpfDBContext>, IWorkflowOfficeTypeRepository
    {
        public WorkflowOfficeTypeFuncMappingRepository(NgIpfDBContext context) : base(context)
       {
       }
    }
}