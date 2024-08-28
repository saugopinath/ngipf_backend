using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NGIPF_BE.BAL.Interfaces;
using NGIPF_BE.DTOs;
using NGIPF_BE.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using NGIPF_BE.BAL;

namespace NGIPF_BE.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MasterController : ControllerBase
    {
        private readonly ITreasuryService _treasuryService;
        private readonly ILfplopService _lfplopService;
        private readonly INgipfOfficeService _ingipfOfficeService;
        private readonly IHoaService _iHoaService;
        private readonly IDdoService _iDdoService;
        public MasterController(ITreasuryService treasuryService, ILfplopService lfplopService, INgipfOfficeService ngipfOfficeService, IHoaService HoaService, IDdoService DdoService)
        {
            _treasuryService = treasuryService;
            _lfplopService = lfplopService;
            _ingipfOfficeService = ngipfOfficeService;
            _iHoaService = HoaService;
            _iDdoService = DdoService;
        }
        [HttpGet("get-treasuries")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> Treasuries()
        {
            APIResponse<List<DropdownStringCodeDTO>> response = new();  
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;
                
                response.result =  await _treasuryService.GetTreasurys(); 
                response.Message = "";
                return response ;
            }
            catch (Exception Ex)
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Error;
                response.Message = Ex.Message;
                return response;
            }
        }
        [HttpGet("get-lfplops")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> Lfplops()
        {
            APIResponse<List<DropdownStringCodeDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _lfplopService.GetLfplops();
                response.Message = "";
                return response;
            }
            catch (Exception Ex)
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Error;
                response.Message = Ex.Message;
                return response;
            }
        }
        [HttpGet("get-lfplopoffice")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> GetPfdAdminOffice()
        {
            APIResponse<List<DropdownStringCodeDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _ingipfOfficeService.GetPfdAdminOffice();
                response.Message = "";
                return response;
            }
            catch (Exception Ex)
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Error;
                response.Message = Ex.Message;
                return response;
            }
        }
        [HttpGet("get-sanctionoffice")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> GetSanctionAuthOffice()
        {
            APIResponse<List<DropdownStringCodeDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _ingipfOfficeService.GetSanctionAuthOffice();
                response.Message = "";
                return response;
            }
            catch (Exception Ex)
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Error;
                response.Message = Ex.Message;
                return response;
            }
        }
        [HttpGet("get-recomandingoffice")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> GetRecomandingAuthOffice()
        {
            APIResponse<List<DropdownStringCodeDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _ingipfOfficeService.GetRecomandingAuthOffice();
                response.Message = "";
                return response;
            }
            catch (Exception Ex)
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Error;
                response.Message = Ex.Message;
                return response;
            }
        }
        [HttpGet("get-hoa")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> GetHoa()
        {
            APIResponse<List<DropdownStringCodeDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _iHoaService.GetHoas();
                response.Message = "";
                return response;
            }
            catch (Exception Ex)
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Error;
                response.Message = Ex.Message;
                return response;
            }
        }
        [HttpGet("get-ddo")]
        public async Task<APIResponse<List<DropdownStringCodeDTO>>> GetDdo()
        {
            APIResponse<List<DropdownStringCodeDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _iDdoService.GetDdos();
                response.Message = "";
                return response;
            }
            catch (Exception Ex)
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Error;
                response.Message = Ex.Message;
                return response;
            }
        }

    }
}