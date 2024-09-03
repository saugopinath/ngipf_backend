using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("mm_gen_ddo", Schema = "ifmsadmin")]
[Index("DdoCode", Name = "mm_gen_ddo_ddo_code_key", IsUnique = true)]
public partial class MmGenDdo
{
    [Column("treasury_code")]
    [StringLength(4)]
    public string? TreasuryCode { get; set; }

    [Column("ddo_code")]
    [StringLength(9)]
    public string? DdoCode { get; set; }

    [Column("ddo_type")]
    [StringLength(1)]
    public string? DdoType { get; set; }

    [Column("valid_upto")]
    public DateOnly? ValidUpto { get; set; }

    [Column("designation")]
    [StringLength(200)]
    public string? Designation { get; set; }

    [Column("address")]
    [StringLength(200)]
    public string? Address { get; set; }

    [Column("phone_no1")]
    [StringLength(20)]
    public string? PhoneNo1 { get; set; }

    [Column("phone_no2")]
    [StringLength(20)]
    public string? PhoneNo2 { get; set; }

    [Column("fax")]
    [StringLength(20)]
    public string? Fax { get; set; }

    [Column("e_mail")]
    [StringLength(50)]
    public string? EMail { get; set; }

    [Column("pin")]
    [StringLength(6)]
    public string? Pin { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("ddo_tan_no")]
    [StringLength(10)]
    public string? DdoTanNo { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("office_name")]
    [StringLength(100)]
    public string? OfficeName { get; set; }

    [Column("station")]
    [StringLength(50)]
    public string? Station { get; set; }

    [Column("controlling_officer")]
    [StringLength(50)]
    public string? ControllingOfficer { get; set; }

    [Column("enrolement_no")]
    [StringLength(25)]
    public string? EnrolementNo { get; set; }

    [Column("nps_registration_no")]
    [StringLength(20)]
    public string? NpsRegistrationNo { get; set; }

    [Column("gstin")]
    [StringLength(255)]
    public string? Gstin { get; set; }

    [Column("parent_treasury_code")]
    [StringLength(10)]
    public string? ParentTreasuryCode { get; set; }

    [Column("int_ddo_id_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Key]
    [Column("int_ddo_id")]
    public int IntDdoId { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("int_dept_id_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("int_dept_id")]
    public int? IntDeptId { get; set; }

    [Column("int_dept_id_hrms_old")]
    [StringLength(38)]
    public string? IntDeptIdHrmsOld { get; set; }

    [Column("int_dept_id_hrms")]
    public int? IntDeptIdHrms { get; set; }

    [InverseProperty("IntDdo")]
    public virtual ICollection<EmpPfBasicDetail> EmpPfBasicDetails { get; set; } = new List<EmpPfBasicDetail>();

    [InverseProperty("IntDdo")]
    public virtual ICollection<HrMdGenDdoSalaryHeadMap> HrMdGenDdoSalaryHeadMaps { get; set; } = new List<HrMdGenDdoSalaryHeadMap>();

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }

    [InverseProperty("IntDdo")]
    public virtual ICollection<PlPfDdoHoaMap> PlPfDdoHoaMaps { get; set; } = new List<PlPfDdoHoaMap>();
}
