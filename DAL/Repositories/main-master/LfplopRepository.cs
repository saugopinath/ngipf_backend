using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
namespace ngipf_frontend.DAL
{
   public class LfplopRepository : Repository<TMmGenPlOperator, NgIpfDBContext>, ILfplopRepository
    {
       public LfplopRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}