using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
{
    public class WorkflowUserMappingService:IWorkflowUserMappingService
    {
        
        private readonly IWorkflowUserMappingRepository _WorkflowUserMappingRepository;
        private readonly IMapper _mapper;
        public WorkflowUserMappingService(IWorkflowUserMappingRepository WorkflowUserMappingRepository, IMapper mapper) {
            _WorkflowUserMappingRepository = WorkflowUserMappingRepository;
            _mapper = mapper;
        }
        
    }
}