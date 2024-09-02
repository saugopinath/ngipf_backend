using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;

namespace ngipf_frontend.DAL
{
    public class StakeHolderMappingRepository : Repository<StakeHolderMapping, NgIpfDBContext>, IStakeHolderMappingRepository
    {
        public StakeHolderMappingRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
}
