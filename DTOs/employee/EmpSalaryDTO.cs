namespace NGIPF_BE.DTOs
{
    public class EmpSalaryDTO
    {
        
        public string? SalarySource { get; set; }
        public string? PFtransferFrom { get; set; }
        public string? Ropa { get; set; }
        public date? RopaEF { get; set; }
        public float BasicPay { get; set; }
        public date? BasicPayEF { get; set; }
        public float GradePay { get; set; }
        public date? GradeEF { get; set; }
    }
}
