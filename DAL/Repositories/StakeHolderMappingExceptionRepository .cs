using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;

namespace ngipf_backend.DAL
{
    public class StakeHolderMappingExceptionRepository  : Repository<StakeHolderMappingException, NgIpfDBContext>, IStakeHolderMappingExceptionRepository
    {
        public StakeHolderMappingExceptionRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
}
