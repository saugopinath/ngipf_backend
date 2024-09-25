using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
   public class StatusMasterRepository : Repository<StatusMaster, NgIpfDBContext>, IStatusMasterRepository
   {
       public StatusMasterRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}