using AutoMapper;
using AutoMapper;
using ngipf_frontend.BAL.Interfaces;
using ngipf_frontend.DAL;
using ngipf_frontend.DAL.Entities;
using ngipf_frontend.DAL.Interfaces;
using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL
{
    public class EmpPfBasicService : IEmpPfBasicService
    {
        private readonly IEmpPfBasicRepository _EmpPfBasicRepository;
        private readonly IMapper _mapper;
        public EmpPfBasicService(IEmpPfBasicRepository EmpPfBasicRepository, IMapper mapper)
        {
            _EmpPfBasicRepository = EmpPfBasicRepository;
            _mapper = mapper;
        }
        //public async Task<List<EmpListViewDTO>> GetEmpList(int tresuary_code, int op_code, int salary_source,int sanction_code = 0, int recomanding_code = 0, string pf_account_no = null, string emp_id = null)
        //{
        //    return (List<DropdownStringCodeDTO>)await _EmpPfBasicRepository.GetSelectedColumnByConditionAsync(entity => entity.IntEmployeeId != null && entity.IntDdo != null , entity => new DropdownStringCodeDTO
        //    {
               
        //    });
        //}
        public async Task<List<EmpListViewDTO>> GetEmpList(DynamicListQueryParameters dynamicListQueryParameters)
        {
            return (List<EmpListViewDTO>)await _EmpPfBasicRepository.GetSelectedColumnByConditionAsync(entity =>true, entity => new DropdownStringCodeDTO
            {

            },dynamicListQueryParameters);
        }
    }
}