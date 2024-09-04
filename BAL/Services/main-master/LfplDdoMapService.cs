using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
using static Dapper.SqlMapper;
namespace ngipf_backend.BAL
{
    public class LfplDdoMapService: ILfplDdoMapService
    {
        private readonly ILfplDdoMapRepository _LfplDdoMapRepository;
        private readonly IMapper _mapper;
        public LfplDdoMapService(ILfplDdoMapRepository LfplDdoMapRepository, IMapper mapper) {
            _LfplDdoMapRepository = LfplDdoMapRepository;
            _mapper = mapper;
        }
        public async Task<List<OperatorListCommonDTO>> GetList(int int_hoa_id = 0, int int_treasury_id = 0, int int_ddo_id = 0, int int_operator_id = 0)
        {
            var filterexpression = "1=1";
            if (int_hoa_id>0)
            {
                filterexpression = filterexpression + "&& entity.IntHoaId=" + int_hoa_id;
            }
            if (int_treasury_id > 0)
            {
                filterexpression = filterexpression + "&& entity.IntTreasuryId=" + int_treasury_id;
            }
            if (int_ddo_id > 0)
            {
                filterexpression = filterexpression + "&& entity.IntDdoId=" + int_ddo_id;
            }
            if (int_operator_id > 0)
            {
                filterexpression = filterexpression + "&& entity.IntOperatorId=" + int_operator_id;
            }
            return (List<OperatorListCommonDTO>)await _LfplDdoMapRepository.GetSelectedColumnByConditionWithSortAsync(entity=> filterexpression, entity => new OperatorListCommonDTO
            {
                
                IntOperatorId = entity.IntOperatorId,
                OperatorName = entity.IntOperator.OperatorName.ToString(),
                IntOperatorCode = entity.IntOperator.OperatorId,
                IntDdoId =entity.IntDdoId,
                DdoName = entity.IntDdo.Designation.ToString(),
                IntHoaId =entity.IntHoaId,
                Hoa = entity.IntHoa.Hoa.ToString(),
                IntTreasuryId =entity.IntTreasuryId,
                TreasuryCode = entity.IntTreasury.TreasuryCode,
                TreasuryName =entity.IntTreasury.TreasuryName.ToString(),
                IntSchemeHead=entity.IntSchemeId,
                SchemeHeadName=entity.IntScheme.Description.ToString(),
            },"IntTreasuryId","ASC");


        }
    }
}