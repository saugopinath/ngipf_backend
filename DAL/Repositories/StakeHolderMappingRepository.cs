using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;

namespace ngipf_backend.DAL
{
    public class StakeHolderMappingRepository : Repository<StakeHolderMapping, NgIpfDBContext>, IStakeHolderMappingRepository
    {
        public StakeHolderMappingRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
}
