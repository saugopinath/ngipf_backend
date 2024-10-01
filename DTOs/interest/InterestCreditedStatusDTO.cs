namespace ngipf_backend.DTOs
{
    public class InterestCreditedStatusDTO
    {
        public int Id { get; set; }
        public short OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string TreasuryCode {  get; set; }
        public string IntTransfer {get;set;}    
        public string InterestYearUpto {  get; set; }   
        public string Status { get; set; }
        public string OpenFrom { get; set; }
        public string PermisionStatus { get; set; }
        public string Action { get; set; }
     
    
    }
}
