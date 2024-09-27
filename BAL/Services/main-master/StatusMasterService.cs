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
        public StatusMasterService(IStatusMasterRepository StatusMasterRepository, IMapper mapper) {
            _statusMasterRepository = StatusMasterRepository;
            _mapper = mapper;
        }
        public async Task<List<DropdownIntCodeDTO>> GetList(int master_type_id) 
        {
            return (List<DropdownIntCodeDTO>)await _statusMasterRepository.GetSelectedColumnByConditionAsync(entity => entity.MasterTypeId == master_type_id, entity => new DropdownIntCodeDTO
            {
                Name = entity.MasterDescr,
                Code = entity.IntMasterId,
            });
        }
    }
}