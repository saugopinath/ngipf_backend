using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
namespace ngipf_frontend.DAL
{
   public class DdoRepository : Repository<MmGenDdo, NgIpfDBContext>, IDdoRepository
   {
       public DdoRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}