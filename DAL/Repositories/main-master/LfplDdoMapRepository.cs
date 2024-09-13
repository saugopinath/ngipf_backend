using Microsoft.EntityFrameworkCore;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;

namespace ngipf_backend.DAL
{
   public class LfplDdoMapRepository : Repository<PlPfDdoHoaMap, NgIpfDBContext>, ILfplDdoMapRepository
    {
       public LfplDdoMapRepository(NgIpfDBContext context) : base(context)
       {
       }

        public async Task<List<TresuryDTO>> GetTresury(int int_hoa_id)
        {
            var tresuryids = NgIpfDBContext.PlPfDdoHoaMaps
             .Where(a => a.IntHoaId == int_hoa_id)//if you have any condition
             .Select(m => m.IntTreasuryId).Distinct();

            var posts = await NgIpfDBContext.MmGenTreasuries
             .Where(p => tresuryids.Contains(p.IntTreasuryId))
             .ToListAsync();

            return (List<TresuryDTO>)await NgIpfDBContext.MmGenTreasuries(dynamicListQueryParametersCommon, entity => new TresuryDTO
            {
                Id = entity.IntPlPfDdoMap,
                IntOperatorId = entity.IntOperatorId,
                OperatorName = entity.IntOperator.OperatorName.ToString(),
                IntOperatorCode = entity.IntOperator.OperatorId,
                IntDdoId = entity.IntDdoId,
                DdoName = entity.IntDdo.Designation.ToString(),
                IntHoaId = entity.IntHoaId,
                Hoa = entity.IntHoa.Hoa.ToString(),
                IntTreasuryId = entity.IntTreasuryId,
                TreasuryCode = entity.IntTreasury.TreasuryCode,
                TreasuryName = entity.IntTreasury.TreasuryName.ToString(),
                IntSchemeHead = entity.IntSchemeId,
                SchemeHeadName = entity.IntScheme.Description.ToString(),
            });

        }
    }
}