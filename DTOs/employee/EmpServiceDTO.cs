namespace ngipf_frontend.DTOs
{
    public class EmpServiceDTO
    {
        
        public string? OldGpfId { get; set; }
        public string? pfAccountStatus { get; set; }
        public DateOnly? DateOfJoining { get; set; }
        public int? ApprovalNumber { get; set; }
        public DateOnly? ApprovalDate { get; set; }
        public DateOnly? ApprovalDateEF { get; set; }
        public string? EmpType { get; set; }
        public DateOnly? EmpTypeEF { get; set; }
        public string? Designation { get; set; }
        public DateOnly? DesignationEF { get; set; }
        public string? CpfOrGpf { get; set; }
        public DateOnly? RetirementDate { get; set; }
        public string? TypeOfTermination { get; set; }
        public DateOnly? TypeOfTerminationEF { get; set; }
    }
}
