using ngipf_backend.DAL.Entities;
namespace ngipf_backend.DAL.Interfaces
{
   
    public class LfPlOpInterestCreditedStatusRepository : Repository<LfPlOpInterestCreditedStatus, NgIpfDBContext>, ILfPlOpInterestCreditedStatusRepository
    {
        public LfPlOpInterestCreditedStatusRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
}