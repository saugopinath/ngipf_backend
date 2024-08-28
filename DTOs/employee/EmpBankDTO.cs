namespace NGIPF_BE.DTOs
{
    public class EmpBankDTO
    {
        
        public string? IFSC { get; set; }
        public string? BankName { get; set; }
        public string? AccountNumber { get; set; }
        public string? BeneficiaryName { get; set; }
        public date? BankDetailsEF { get; set; }
        public string? Remarks { get; set; }
    }
}
