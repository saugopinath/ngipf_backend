using AutoMapper;
using AutoMapper;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Entities;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.DTOs;

namespace ngipf_backend.BAL
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
        public async Task<IEnumerable<EmpListViewDTO>> GetEmpList(string tresuary_code, int op_code, int salary_source, DynamicListQueryParameters dynamicListQueryParameters)
        {

            return await _EmpPfBasicRepository.GetSelectedColumnByConditionAsync(entity => entity.IntTreasuryCode == tresuary_code && entity.IntOperatorId == op_code && entity.IntSalarySource == salary_source, entity => new EmpListViewDTO
            {
                PFAccountNumber = entity.PfAacountNo,
                //NameWithEmpid = String.Format("{0} {1} {2} {3} ({4})", entity.EmpFirstName, entity.EmpMidName, entity.EmpLastName, entity.EmpId),
                NameWithEmpid = entity.EmpFirstName+"  "+entity.EmpMidName + "  " + entity.EmpLastName + " ( " + entity.EmpId+" )",
                Doj = entity.DateOfJoining.Value.ToString("dd/MM/yyyy"),
                Status = entity.StatusNavigation.MasterAbbr,
                IntEmployeeId = entity.IntEmployeeId
            }, dynamicListQueryParameters);
            
        }
    }
}