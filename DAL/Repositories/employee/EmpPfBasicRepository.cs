using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;

namespace ngipf_backend.DAL
{
    public class EmpPfBasicRepository : Repository<EmpPfBasicDetail, NgIpfDBContext>, IEmpPfBasicRepository
    {
        public EmpPfBasicRepository(NgIpfDBContext context) : base(context)
        {
        }
    }
}
