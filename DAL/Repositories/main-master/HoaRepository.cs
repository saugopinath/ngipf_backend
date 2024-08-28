using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
namespace ngipf_frontend.DAL
{
   public class HoaRepository : Repository<DeptHoaMapping, NgIpfDBContext>, IHoaRepository
   {
       public HoaRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}