using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
namespace ngipf_backend.DAL
{
   public class TreasuryRepository : Repository<MmGenTreasury, NgIpfDBContext>, ITreasuryRepository
   {
       public TreasuryRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}