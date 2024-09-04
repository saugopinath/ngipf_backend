namespace ngipf_backend.DTOs
{
    public class OperatorListCommonDTO
    {
        public int IntOperatorId { get; set; }
        public int IntOperatorCode { get; set; }
        public string OperatorName { get; set; }
        public int IntDdoId { get; set; }
        public string? DdoName { get; set; }
        public int IntHoaId { get; set; }
        public string Hoa { get; set; }
        public int IntTreasuryId { get; set; }
        public string TreasuryCode{ get; set; }
        public string TreasuryName { get; set; }
        public int IntSchemeHead { get; set; }
        public string SchemeHeadName { get; set; }
    }
}
