using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
   public class WorkflowOfficeTypeRepository : Repository<WorkflowOfficeTypeMst, NgIpfDBContext>, IWorkflowOfficeTypeRepository
   {
       public WorkflowOfficeTypeRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}