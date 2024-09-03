using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
{
    public class WorkflowOfficeTypeFuncMappingService:IWorkflowOfficeTypeFuncMappingService
    {
        
        private readonly IWorkflowOfficeTypeFuncMappingRepository _WorkflowOfficeTypeFuncMappingRepository;
        private readonly IMapper _mapper;
        public WorkflowOfficeTypeFuncMappingService(IWorkflowOfficeTypeFuncMappingRepository WorkflowOfficeTypeFuncMappingRepository, IMapper mapper) {
            _WorkflowOfficeTypeFuncMappingRepository = WorkflowOfficeTypeFuncMappingRepository;
            _mapper = mapper;
        }
        

    }
}