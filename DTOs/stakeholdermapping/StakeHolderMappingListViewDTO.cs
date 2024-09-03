namespace ngipf_backend.DTOs
{
    public class StakeHolderMappingListViewDTO
    {
        public string? HOA { get; set; } 
        public string SanctionAdminCount { get; set; }
        public string? SanctionAdminNature { get; set; }
        public string? RecomandingAuthRequired { get; set; }
        public string RecomandingAuthCount { get; set; }
        public string? RecomandingAuthNature { get; set; }
        public int? ExceptionCount { get; set; }
    }
}
