using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;

namespace ngipf_frontend.DAL.Repositories.main_master
{
    public class NgipfOfficeRepository : Repository<MmGenNgipfOffice, NgIpfDBContext>, INgipfOfficeRepository
    {
        public NgipfOfficeRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
    
}
