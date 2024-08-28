using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;

namespace NGIPF_BE.DAL.Repositories.main_master
{
    public class NgipfOfficeRepository : Repository<MmGenNgipfOffice, NgIpfDBContext>, INgipfOfficeRepository
    {
        public NgipfOfficeRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
    
}
