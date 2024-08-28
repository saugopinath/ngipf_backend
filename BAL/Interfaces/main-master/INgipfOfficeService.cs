using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface INgipfOfficeService
    {
        public Task<List<DropdownStringCodeDTO>> GetNgipfOffices();
        public Task<List<DropdownStringCodeDTO>> GetPfdAdminOffice();
        public Task<List<DropdownStringCodeDTO>> GetSanctionAuthOffice();
        public Task<List<DropdownStringCodeDTO>> GetRecomandingAuthOffice();
    }

}