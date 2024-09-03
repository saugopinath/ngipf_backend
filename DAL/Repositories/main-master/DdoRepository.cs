using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
   public class DdoRepository : Repository<MmGenDdo, NgIpfDBContext>, IDdoRepository
   {
       public DdoRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}