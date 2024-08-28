using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpSearchService
    {
        public Task<List<EmpListViewDTO>> GetEmpList(int tresuary_code,int op_code,int sanction_code = 0,int recomanding_code = 0,string pf_account_no = null,string emp_id = null,int salary_source = 0);
    }
}