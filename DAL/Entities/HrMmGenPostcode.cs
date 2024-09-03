using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_postcode", Schema = "ihrms_master")]
public partial class HrMmGenPostcode
{
    [Column("POST_CODE")]
    [StringLength(50)]
    public string? PostCode { get; set; }

    [Column("FLAG_SANCTIONED")]
    [StringLength(1)]
    public string? FlagSanctioned { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("VACANT_FLAG")]
    [StringLength(1)]
    public string? VacantFlag { get; set; }

    [Column("REMARKS")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("FLAG_OWN_OTHER")]
    [StringLength(5)]
    public string? FlagOwnOther { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("PROPOSED_MODULE")]
    [StringLength(50)]
    public string? ProposedModule { get; set; }

    [Column("INT_POST_CODE_old")]
    [StringLength(38)]
    public string? IntPostCodeOld { get; set; }

    [Column("INT_POST_CODE")]
    public int? IntPostCode { get; set; }

    [Column("INT_TD_SANCTION_POST_old")]
    [StringLength(38)]
    public string? IntTdSanctionPostOld { get; set; }

    [Column("INT_TD_SANCTION_POST")]
    public int? IntTdSanctionPost { get; set; }

    [Column("OTHER_AA_CODE_old")]
    [StringLength(38)]
    public string? OtherAaCodeOld { get; set; }

    [Column("OTHER_AA_CODE")]
    public int? OtherAaCode { get; set; }

    [Column("INT_ZONE_CODE_old")]
    [StringLength(38)]
    public string? IntZoneCodeOld { get; set; }

    [Column("INT_ZONE_CODE")]
    public int? IntZoneCode { get; set; }

    [Column("PROPOSED_EMPLOYEE_ID_old")]
    [StringLength(38)]
    public string? ProposedEmployeeIdOld { get; set; }

    [Column("PROPOSED_EMPLOYEE_ID")]
    public int? ProposedEmployeeId { get; set; }

    [Column("INT_POST_ID_old")]
    [StringLength(38)]
    public string? IntPostIdOld { get; set; }

    [Column("INT_POST_ID")]
    public int? IntPostId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("INT_TD_SANCTION_POST_INACTIVE_old")]
    [StringLength(38)]
    public string? IntTdSanctionPostInactiveOld { get; set; }

    [Column("INT_TD_SANCTION_POST_INACTIVE")]
    public int? IntTdSanctionPostInactive { get; set; }

    [Column("INT_POSTCODE_SECTION_ID_old")]
    [StringLength(38)]
    public string? IntPostcodeSectionIdOld { get; set; }

    [Column("INT_POSTCODE_SECTION_ID")]
    public int? IntPostcodeSectionId { get; set; }
}
