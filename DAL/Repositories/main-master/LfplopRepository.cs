using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
namespace NGIPF_BE.DAL
{
   public class LfplopRepository : Repository<TMmGenPlOperator, NgIpfDBContext>, ILfplopRepository
    {
       public LfplopRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}