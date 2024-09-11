using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DTOs;
using ngipf_backend.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using ngipf_backend.BAL;

namespace ngipf_backend.Controllers
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
        private readonly ILfplDdoMapService _iLfplDdoMapService;
        public MasterController(ITreasuryService treasuryService, ILfplopService lfplopService, INgipfOfficeService ngipfOfficeService, IHoaService HoaService, IDdoService DdoService, ILfplDdoMapService LfplDdoMapService)
        {
            _treasuryService = treasuryService;
            _lfplopService = lfplopService;
            _ingipfOfficeService = ngipfOfficeService;
            _iHoaService = HoaService;
            _iDdoService = DdoService;
            _iLfplDdoMapService = LfplDdoMapService;
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
        [HttpGet("get-LfplDdoMap")]
        public async Task<APIResponse<List<OperatorListCommonDTO>>> LfplDdoMap(int int_hoa_id=0, int int_treasury_id=0 , int int_ddo_id=0 , int int_operator_id=0)
        {
            APIResponse<List<OperatorListCommonDTO>> response = new();
            try
            {
                response.apiResponseStatus = Enum.APIResponseStatus.Success;

                response.result = await _iLfplDdoMapService.GetList(int_hoa_id,int_treasury_id , int_ddo_id , int_operator_id );
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