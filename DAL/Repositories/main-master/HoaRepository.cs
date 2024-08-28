using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
namespace NGIPF_BE.DAL
{
   public class HoaRepository : Repository<DeptHoaMapping, NgIpfDBContext>, IHoaRepository
   {
       public HoaRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}