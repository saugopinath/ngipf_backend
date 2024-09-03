using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
{
    public class WorkflowOfficeTypeService:IWorkflowOfficeTypeService
    {
        private readonly IWorkflowOfficeTypeRepository _WorkflowOfficeTypeRepository;
        private readonly IMapper _mapper;
        public WorkflowOfficeTypeService(IWorkflowOfficeTypeRepository WorkflowOfficeTypeRepository, IMapper mapper)
        {
            _WorkflowOfficeTypeRepository = WorkflowOfficeTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<DropdownStringCodeDTO>> GetList()
        {
            return (List<DropdownStringCodeDTO>)await _WorkflowOfficeTypeRepository.GetSelectedColumnByConditionAsync(entity => true, entity => new DropdownStringCodeDTO
            {
                Name = entity.Name,
                Code = entity.Id.ToString(),
            });
        }
    }
}