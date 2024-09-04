using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
   public class LfplDdoMapRepository : Repository<PlPfDdoHoaMap, NgIpfDBContext>, ILfplDdoMapRepository
    {
       public LfplDdoMapRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}