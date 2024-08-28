using NGIPF_BE.DTOs;

namespace NGIPF_BE.BAL.Interfaces
{
    public interface IEmpPfBasicService
    {
        public Task<List<EmpListViewDTO>> GetEmpList();
         public Task<List<EmpListViewDTO>> GetEmpList(int empId);
    }
}