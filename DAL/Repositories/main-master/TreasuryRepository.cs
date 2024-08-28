using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
namespace ngipf_frontend.DAL
{
   public class TreasuryRepository : Repository<MmGenTreasury, NgIpfDBContext>, ITreasuryRepository
   {
       public TreasuryRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}