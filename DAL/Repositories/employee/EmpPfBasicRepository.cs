using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;

namespace ngipf_frontend.DAL
{
    public class EmpPfBasicRepository : Repository<EmpPfBasicDetail, NgIpfDBContext>, IEmpPfBasicRepository
    {
        public EmpPfBasicRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
}
