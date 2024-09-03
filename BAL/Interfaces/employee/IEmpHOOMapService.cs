using ngipf_backend.DTOs;

namespace ngipf_backend.BAL.Interfaces
{
    public interface IEmpHOOMapService
    {
        public Task<List<EmpOfficeDTO>> GetEmpHOOMap(int empId);
    }
}