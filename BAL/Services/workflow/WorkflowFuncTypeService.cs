using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
{
    public class WorkflowFuncTypeService:IWorkflowFuncTypeService
    {
       
        private readonly IWorkflowFuncTypeRepository _WorkflowFuncTypeRepository;
        private readonly IMapper _mapper;
        public WorkflowFuncTypeService(IWorkflowFuncTypeRepository WorkflowFuncTypeRepository, IMapper mapper) {
            _WorkflowFuncTypeRepository =WorkflowFuncTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<DropdownStringCodeDTO>> GetList() 
        {
            return (List<DropdownStringCodeDTO>)await _WorkflowFuncTypeRepository.GetSelectedColumnByConditionWithSortAsync(entity => true, entity => new DropdownStringCodeDTO
            {
                Name = entity.Name,
                Code = entity.Id.ToString(),
            }, "DisplayRank", "ASC");
        }
    }
}