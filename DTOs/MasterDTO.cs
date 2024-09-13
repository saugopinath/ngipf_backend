using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ngipf_backend.DTOs;
namespace ngipf_backend.DTOs
{
   
    public class TresuryDTO: DropdownStringCodeDTO
    {
      
        public string TreasuryCode { get; set; }
        public string TreasuryName { get; set; }
        public string? DistrictCode { get; set; }
        public string? TreasurySrlNumber { get; set; }
        public string? OfficerName { get; set; }
        public string? Address { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? PhoneNo1 { get; set; }
        public string? PhoneNo2 { get; set; }
        public string? Fax { get; set; }
        public string? EMail { get; set; }
        public string? Pin { get; set; }
        public int IntTreasuryId { get; set; }

    }
   

}
