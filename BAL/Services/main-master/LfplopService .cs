using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
using static Dapper.SqlMapper;
namespace ngipf_backend.BAL
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