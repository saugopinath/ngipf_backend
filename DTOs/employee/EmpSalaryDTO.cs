namespace ngipf_frontend.DTOs
{
    public class EmpSalaryDTO
    {
        
        public string? SalarySource { get; set; }
        public string? PFtransferFrom { get; set; }
        public string? Ropa { get; set; }
        public DateOnly? RopaEF { get; set; }
        public float BasicPay { get; set; }
        public DateOnly? BasicPayEF { get; set; }
        public float GradePay { get; set; }
        public DateOnly? GradeEF { get; set; }
    }
}
