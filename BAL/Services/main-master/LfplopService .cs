using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;
using static Dapper.SqlMapper;
namespace NGIPF_BE.BAL
{
    public class LfplopService : ILfplopService
    {
        private readonly ILfplopRepository _LfplopRepository;
        private readonly IMapper _mapper;
        public LfplopService(ILfplopRepository LfplopRepository, IMapper mapper) {
            _LfplopRepository = LfplopRepository;
            _mapper = mapper;
        }
        public async Task<List<DropdownStringCodeDTO>> GetLfplops()
        {
           
            return (List<DropdownStringCodeDTO>)await _LfplopRepository.GetSelectedColumnByConditionAsync(entity => entity.IntPlOperatorId != null, entity => new DropdownStringCodeDTO
            {
                Name = entity.OperatorName,
                Code = entity.IntPlOperatorId.ToString(),
            });


        }
    }
}