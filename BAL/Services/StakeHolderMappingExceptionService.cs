using AutoMapper;
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DAL;
using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL
{
    public class StakeHolderMappingExceptionService : IStakeHolderMappingExceptionService
    {
        private readonly IStakeHolderMappingExceptionRepository _StakeHolderMappingExceptionRepository;
        public StakeHolderMappingExceptionService(IStakeHolderMappingExceptionRepository StakeHolderMappingExceptionRepository)
        {
            _StakeHolderMappingExceptionRepository = StakeHolderMappingExceptionRepository;
           
        }
        public async Task<int> GetExceptionMappingCount(int int_hoa_id)
        {
            
        }
    }
}