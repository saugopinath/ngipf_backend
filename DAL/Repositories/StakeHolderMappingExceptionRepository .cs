using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;

namespace ngipf_frontend.DAL
{
    public class StakeHolderMappingExceptionRepository  : Repository<StakeHolderMappingException, NgIpfDBContext>, IStakeHolderMappingExceptionRepository
    {
        public StakeHolderMappingExceptionRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
}
