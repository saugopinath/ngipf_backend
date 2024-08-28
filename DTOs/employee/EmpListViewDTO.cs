namespace ngipf_frontend.DTOs
{
    public class EmpListViewDTO
    {
        public string? PFAccountNumber { get; set; } 
        public string? EmpId { get; set; }
        public string? Name { get; set; }
        public DateOnly? Doj { get; set; }
        public string? Status { get; set; }
    }
}
