using ngipf_frontend.DTOs;

namespace ngipf_frontend.BAL.Interfaces
{
    public interface IEmpHOOMapService
    {
        public Task<List<EmpOfficeDTO>> GetEmpHOOMap(int empId);
    }
}