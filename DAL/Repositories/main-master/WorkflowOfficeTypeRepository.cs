using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
namespace ngipf_frontend.DAL
{
   public class WorkflowOfficeTypeRepository : Repository<WorkflowOfficeTypeMst, NgIpfDBContext>, IWorkflowOfficeTypeRepository
   {
       public WorkflowOfficeTypeRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}