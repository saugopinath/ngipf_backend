using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpPfBasicService
    {
        public Task<IEnumerable<EmpListViewDTO>> GetEmpList(string tresuary_code, int op_code, int salary_source, DynamicListQueryParameters dynamicListQueryParameters);

    }
}