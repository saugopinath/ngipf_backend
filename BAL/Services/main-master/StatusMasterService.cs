using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
{
    public class StatusMasterService : IStatusMasterService
    {
        private readonly IStatusMasterRepository _statusMasterRepository;
        private readonly IMapper _mapper;
        public DdoService(IStatusMasterRepository StatusMasterRepository, IMapper mapper) {
            _statusMasterRepository = StatusMasterRepository;
            _mapper = mapper;
        }
        public async Task<List<DropdownStringCodeDTO>> GetList() 
        {
            return (List<DropdownStringCodeDTO>)await _statusMasterRepository.GetSelectedColumnByConditionAsync(entity => TRUE, entity => new DropdownStringCodeDTO
            {
                Name = entity.Designation,
                Code = entity.DdoCode,
            });
        }
    }
}