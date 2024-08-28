using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
namespace NGIPF_BE.DAL
{
   public class TreasuryRepository : Repository<MmGenTreasury, NgIpfDBContext>, ITreasuryRepository
   {
       public TreasuryRepository(NgIpfDBContext context) : base(context)
       {
       }
   }
}