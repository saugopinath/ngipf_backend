namespace ngipf_frontend.DTOs
    
{
    public class EmpAddressDTO
    {
        
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? PreSentLine1 { get; set; }
        public string? PreSentLine2 { get; set; }
        public string? PreSentState { get; set; }
        public string? PreSentDistrict { get; set; }
        public string? PreSentPincode { get; set; }
        public DateOnly? PreSentEFDate { get; set; }
        public string? PresntPermanentIsSame { get; set; }
        public string? PerManentLine1 { get; set; }
        public string? PerManentLine2 { get; set; }
        public string? PerManentState { get; set; }
        public string? PerManentDistrict { get; set; }
        public string? PerManentPincode { get; set; }
        public DateOnly? PerManentEFDate { get; set; }
    }
}
