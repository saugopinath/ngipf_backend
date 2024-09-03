using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IEmpPfBasicService
    {
        public Task<IEnumerable<EmpListViewDTO>> GetEmpList(string tresuary_code, int op_code, int salary_source, DynamicListQueryParameters dynamicListQueryParameters);

    }
}