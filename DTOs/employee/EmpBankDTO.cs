namespace ngipf_backend.DTOs
{
    public class EmpBankDTO
    {
        
        public string? IFSC { get; set; }
        public string? BankName { get; set; }
        public string? AccountNumber { get; set; }
        public string? BeneficiaryName { get; set; }
        public DateOnly? BankDetailsEF { get; set; }
        public string? Remarks { get; set; }
    }
}
