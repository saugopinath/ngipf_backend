using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;
using ngipf_backend.Enum;

namespace ngipf_backend.BAL
{
    public class StakeHolderMappingExceptionService : IStakeHolderMappingExceptionService
    {
        private readonly IStakeHolderMappingExceptionRepository _StakeHolderMappingExceptionRepository;
        public StakeHolderMappingExceptionService(IStakeHolderMappingExceptionRepository StakeHolderMappingExceptionRepository)
        {
            _StakeHolderMappingExceptionRepository = StakeHolderMappingExceptionRepository;
           
        }
       
        public  int GetExceptionMappingCount(int int_hoa_id)
        {
            return _StakeHolderMappingExceptionRepository.CountWithCondition(entity => entity.IntHoaId == int_hoa_id);
        }

        
    }
}