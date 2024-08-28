using AutoMapper;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DAL.Entities;
using NGIPF_BE.DAL.Interfaces;
using NGIPF_BE.DTOs;
namespace NGIPF_BE.BAL
{
    public class NgipfOfficeService : INgipfOfficeService
    {
        private readonly INgipfOfficeRepository _NgipfOfficeRepository;
        private readonly IMapper _mapper;
        public NgipfOfficeService(INgipfOfficeRepository NgipfOfficeRepository, IMapper mapper) {
            _NgipfOfficeRepository = NgipfOfficeRepository;
            _mapper = mapper;
        }
        public async Task<List<DropdownStringCodeDTO>> GetNgipfOffices()
        {
            return (List<DropdownStringCodeDTO>)await _NgipfOfficeRepository.GetSelectedColumnByConditionAsync(entity => entity.ActiveFlag != null && entity.ActiveFlag == "Y", entity => new DropdownStringCodeDTO
            {
                Name = entity.IntHeadOfOffice.NameOfOffice,
                Code = entity.IntGenNgipfOfficeId.ToString(),
            });
        }
        public async Task<List<DropdownStringCodeDTO>> GetPfdAdminOffice()
        {
            return (List<DropdownStringCodeDTO>)await _NgipfOfficeRepository.GetSelectedColumnByConditionAsync(entity => entity.ActiveFlag != null && entity.ActiveFlag == "Y" && entity.HooType == "O", entity => new DropdownStringCodeDTO
            {
                Name = entity.IntHeadOfOffice.NameOfOffice,
                Code = entity.IntGenNgipfOfficeId.ToString(),
            });
        }
        public async Task<List<DropdownStringCodeDTO>> GetSanctionAuthOffice() 
        {
            return (List<DropdownStringCodeDTO>)await _NgipfOfficeRepository.GetSelectedColumnByConditionAsync(entity => entity.ActiveFlag != null && entity.ActiveFlag == "Y" && entity.HooType == "S", entity => new DropdownStringCodeDTO
            {
                Name = entity.IntHeadOfOffice.NameOfOffice,
                Code = entity.IntGenNgipfOfficeId.ToString(),
            });
        }
        public async Task<List<DropdownStringCodeDTO>> GetRecomandingAuthOffice()
        {
            return (List<DropdownStringCodeDTO>)await _NgipfOfficeRepository.GetSelectedColumnByConditionAsync(entity => entity.ActiveFlag != null && entity.ActiveFlag == "Y" && entity.HooType == "R", entity => new DropdownStringCodeDTO
            {
                Name = entity.IntHeadOfOffice.NameOfOffice,
                Code = entity.IntGenNgipfOfficeId.ToString(),
            });
        }
      

    }
}