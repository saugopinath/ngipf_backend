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
                        Name = x.TreasuryName,
                        Code = x.IntTreasuryId.ToString(),
                        TreasuryCode = x.TreasuryCode,
                        IntTreasuryId = x.IntTreasuryId,
                        TreasuryName = x.TreasuryName
                    }).ToList();
                return t;
            
        }
        public List<PfdAdminDTO> GetPfdAdmin(int int_treasury_id, int int_hoa_id)
        {
            var ids = NgIpfDBContext.PlPfDdoHoaMaps
            .Where(a => a.IntTreasuryId == int_treasury_id && a.IntHoaId == int_hoa_id)//if you have any condition
            .Select(m => m.IntOperatorId).Distinct();


            var t = NgIpfDBContext.TMmGenPlOperators
                  .Where(p => ids.Contains(p.IntPlOperatorId)).OrderBy(a => a.IntPlOperatorId)
                  .Select(x => new PfdAdminDTO
                  {
                      IntOperatorId = x.IntPlOperatorId,
                      OperatorName = x.OperatorName,
                      OperatorCode=x.OperatorId.ToString()
                  }).ToList();
            return t;

        }


    }
}