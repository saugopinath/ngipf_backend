using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;

namespace ngipf_backend.DAL.Repositories.main_master
{
    public class NgipfOfficeRepository : Repository<MmGenNgipfOffice, NgIpfDBContext>, INgipfOfficeRepository
    {
        public NgipfOfficeRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
    
}
