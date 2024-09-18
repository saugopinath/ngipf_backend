using Microsoft.EntityFrameworkCore;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
using System.Diagnostics.Metrics;

namespace ngipf_backend.DAL
{
   public class LfplDdoMapRepository : Repository<PlPfDdoHoaMap, NgIpfDBContext>, ILfplDdoMapRepository
    {
       public LfplDdoMapRepository(NgIpfDBContext context) : base(context)
       {
       }
        public List<TresuryDTO> GetTresury(int int_hoa_id)
        {
            var tresuryids = NgIpfDBContext.PlPfDdoHoaMaps
            .Where(a => a.IntHoaId == int_hoa_id)//if you have any condition
            .Select(m => m.IntTreasuryId).Distinct();

           
              var t = NgIpfDBContext.MmGenTreasuries
                    .Where(p => tresuryids.Contains(p.IntTreasuryId)).OrderBy(a => a.IntTreasuryId)
                    .Select(x => new TresuryDTO
                    {
                        TreasuryCode = x.TreasuryCode,
                        IntTreasuryId = x.IntTreasuryId,
                        TreasuryName = x.TreasuryName
                    }).ToList();
                return t;
            
        }

      
    }
}