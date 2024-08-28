using AutoMapper;
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DAL;
using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
using ngipf_frontend.DTOs;
using static Dapper.SqlMapper;
namespace ngipf_frontend.BAL
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