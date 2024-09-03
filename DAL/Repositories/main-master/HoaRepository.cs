using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
   public class HoaRepository : Repository<NgipfHoaList, NgIpfDBContext>, IHoaRepository
   {
       public HoaRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}