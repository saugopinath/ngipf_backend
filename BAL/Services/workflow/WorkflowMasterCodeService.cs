using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
namespace ngipf_backend.BAL
{
    public class WorkflowMasterCodeService:IWorkflowMasterCodeService
    {
        
        private readonly IWorkflowMasterCodeRepository _WorkflowMasterCodeRepository;
        private readonly IMapper _mapper;
        public WorkflowMasterCodeService(IWorkflowMasterCodeRepository WorkflowMasterCodeRepository, IMapper mapper) {
            _WorkflowMasterCodeRepository = WorkflowMasterCodeRepository;
            _mapper = mapper;
        }
        
    }
}