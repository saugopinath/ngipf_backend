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
        private readonly ITreasuryRepository _TreasuryRepository;
        private readonly IMapper _mapper;
        public LfplDdoMapService(ILfplDdoMapRepository LfplDdoMapRepository, ITreasuryRepository TreasuryRepository, IMapper mapper) {
            _LfplDdoMapRepository = LfplDdoMapRepository;
            _TreasuryRepository = TreasuryRepository;
            _mapper = mapper;
        }
        public async Task<List<OperatorListCommonDTO>> GetList(int int_hoa_id = 0, int int_treasury_id = 0, int int_ddo_id = 0, int int_operator_id = 0)
        {
            DynamicListQueryParametersCommon dynamicListQueryParametersCommon = new DynamicListQueryParametersCommon();
            dynamicListQueryParametersCommon.filterParameters = new List<FilterParameter>();
            dynamicListQueryParametersCommon.sortParameters = new List<SortParameter>();
            if (int_hoa_id>0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntHoaId",
                    Value = int_hoa_id.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParametersCommon.filterParameters.Add(filterParameter);
            }
            if (int_treasury_id > 0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntTreasuryId",
                    Value = int_treasury_id.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParametersCommon.filterParameters.Add(filterParameter);
            }
            if (int_ddo_id > 0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntDdoId",
                    Value = int_ddo_id.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParametersCommon.filterParameters.Add(filterParameter);
            }
            if (int_operator_id > 0)
            {
                FilterParameter filterParameter = new FilterParameter
                {
                    Field = "IntOperatorId",
                    Value = int_operator_id.ToString(),
                    Operator = "equals"
                };
                dynamicListQueryParametersCommon.filterParameters.Add(filterParameter);
            }
            SortParameter sortParameter1 = new SortParameter
            {
                Field = "IntHoaId",
                Order = "ASC"
            };
            dynamicListQueryParametersCommon.sortParameters.Add(sortParameter1);
        
            return (List<OperatorListCommonDTO>) await _LfplDdoMapRepository.getallCommon(dynamicListQueryParametersCommon, entity => new OperatorListCommonDTO
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
        public async Task<List<TresuryDTO>> GetTresuries(int int_hoa_id)
        {
            var tresuryids = _LfplDdoMapRepository.GetTresury(int_hoa_id);
            return tresuryids;

        }
        public async Task<List<PfdAdminDTO>> GetPfdAdmin(int int_treasury_id, int int_hoa_id)
        {
            var ids = _LfplDdoMapRepository.GetPfdAdmin(int_treasury_id,int_hoa_id);
            return ids;

        }

    }
}