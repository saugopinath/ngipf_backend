using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpPfBasicService
    {
        //public Task<List<EmpListViewDTO>> GetEmpList(int tresuary_code, int op_code, int salary_source,int sanction_code = 0, int recomanding_code = 0, string pf_account_no = null, string emp_id = null);
        Task<List<EmpListViewDTO>> GetEmpList(DynamicListQueryParameters dynamicListQueryParameters);
    }
}