using AutoMapper;
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DAL;
using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
using ngipf_frontend.DTOs;
using ngipf_frontend.Enum;

namespace ngipf_frontend.BAL
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