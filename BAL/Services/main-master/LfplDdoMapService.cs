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
            DynamicListQueryParameters dynamicListQueryParameters = new DynamicListQueryParameters();
            dynamicListQueryParameters.filterParameters = new List<FilterParameter>();
            if (int_hoa_id>0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntHoaId",
                    Value = int_hoa_id.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParameters.filterParameters.Add(filterParameter);
            }
            if (int_treasury_id > 0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntTreasuryId",
                    Value = int_treasury_id.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParameters.filterParameters.Add(filterParameter);
            }
            if (int_ddo_id > 0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntDdoId",
                    Value = int_ddo_id.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParameters.filterParameters.Add(filterParameter);
            }
            if (int_operator_id > 0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntOperatorId",
                    Value = int_operator_id.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParameters.filterParameters.Add(filterParameter);
            }
            dynamicListQueryParameters.sortParameters = new SortParameter
            {
                Field = "IntTreasuryId",
                Order = "ASC"
            };
            return (List<OperatorListCommonDTO>)await _LfplDdoMapRepository.getallCommon( dynamicListQueryParameters, entity => new OperatorListCommonDTO
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