using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
   public class LfplopRepository : Repository<TMmGenPlOperator, NgIpfDBContext>, ILfplopRepository
    {
       public LfplopRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}