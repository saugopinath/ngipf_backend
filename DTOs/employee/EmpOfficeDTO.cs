namespace ngipf_frontend.DTOs
{
    public class EmpOfficeDTO
    {
        
        public string? HOODesignation { get; set; }
        public string? HOOCode { get; set; }
        public string? OfficeName { get; set; }
        public string? OfficeCode { get; set; }
        public string? PFAdminName { get; set; }
        public string? PFAdminCode { get; set; }
        public DateOnly? PFAdminDetailsEF { get; set; }
        public string? PFAdminHOA { get; set; }
        public string? PFTreasuryName { get; set; }
        public string? PFTreasuryCode { get; set; }
        public DateOnly? PFTreasuryDetailsEF { get; set; }

        public string? SanctionAdminName { get; set; }
        public string? SanctionAdminCode { get; set; }
        public DateOnly? SanctionAdminDetailsEF { get; set; }

        public string? RecomandingAdminName { get; set; }
        public string? RecomandingAdminCode { get; set; }
        public DateOnly? RecomandingAdminDetailsEF { get; set; }

        public string? EmpPFTreasuryName { get; set; }
        public string? EmpPFTreasuryNameCode { get; set; }
        public DateOnly? EmpPFTreasuryDetailsEF { get; set; }
    }
}
