using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpHOOMapService
    {
        public Task<List<EmpOfficeDTO>> GetEmpHOOMap();
        public Task<List<EmpOfficeDTO>> GetEmpHOOMap(int empId);
    }
}