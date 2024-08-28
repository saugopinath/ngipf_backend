namespace NGIPF_BE.DTOs
{
    public class EmpServiceDTO
    {
        
        public string? OldGpfId { get; set; }
        public string? pfAccountStatus { get; set; }
        public date? DateOfJoining { get; set; }
        public integer? ApprovalNumber { get; set; }
        public date? ApprovalDate { get; set; }
        public date? ApprovalDateEF { get; set; }
        public string? EmpType { get; set; }
        public date? EmpTypeEF { get; set; }
        public string? Designation { get; set; }
        public date? DesignationEF { get; set; }
        public string? CpfOrGpf { get; set; }
        public date? RetirementDate { get; set; }
        public string? TypeOfTermination { get; set; }
        public date? TypeOfTerminationEF { get; set; }
    }
}
