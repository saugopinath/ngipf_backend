using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ngipf_backend.DAL.Entities;
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
    public class PfdAdminDTO 
    {

        public int IntOperatorId { get; set; }

        public string OperatorName { get; set; }

        public string? OperatorCode { get; set; }

        public int? IntDdoId { get; set; }

       
        public string? ActiveFlag { get; set; } 

       
        public int? RoleId { get; set; }

       
        public string? LocalGlobalFlag { get; set; }

      
        public int? IntHoaId { get; set; }

        
        public int? CreatedBy { get; set; }

     
        public int? LastUpdatedBy { get; set; }

        
        public int? DeletedBy { get; set; }

       
        public DateTime? CreatedAt { get; set; }

       
        public DateTime? LastUpdatedAt { get; set; }

      
        public DateTime? DeletedAt { get; set; }

        
        public int? IntTreasuryId { get; set; }

      
        public int? IntSchemeId { get; set; }

       
        public int? IntPlPfDdoMap { get; set; }

       

    }
    public class StatusMasterDTO: DropdownStringCodeDTO
    {
    }


}
