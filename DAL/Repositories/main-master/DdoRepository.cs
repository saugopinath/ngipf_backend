using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
namespace NGIPF_BE.DAL
{
   public class DdoRepository : Repository<MmGenDdo, NgIpfDBContext>, IDdoRepository
   {
       public DdoRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}