namespace ngipf_backend.DTOs
{
    public class EmpListViewDTO
    {
        public string? PFAccountNumber { get; set; } 
        public string NameWithEmpid { get; set; }
        public string? Doj { get; set; }
        public string? Status { get; set; }
        public int IntEmployeeId { get; set; }
    }
}
