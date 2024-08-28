using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_gen_aa_personal_detail", Schema = "ihrms_master")]
public partial class HrMdGenAaPersonalDetail
{
    [Column("AA_NAME")]
    [StringLength(100)]
    public string? AaName { get; set; }

    [Column("AA_OFFICE_PH")]
    [StringLength(20)]
    public string? AaOfficePh { get; set; }

    [Column("OFFICE_ORDER_NO")]
    [StringLength(30)]
    public string? OfficeOrderNo { get; set; }

    [Column("OFFICE_ORDER_DATE")]
    public DateOnly? OfficeOrderDate { get; set; }

    [Column("EMAIL_ID")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("DEFAULT_OFFICE_ADDRESS")]
    [StringLength(3)]
    public string? DefaultOfficeAddress { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(3)]
    public string? ActiveFlag { get; set; }

    [Column("INT_AA_PERSONAL_ID_old")]
    [StringLength(38)]
    public string? IntAaPersonalIdOld { get; set; }

    [Column("INT_AA_PERSONAL_ID")]
    public int? IntAaPersonalId { get; set; }

    [Column("INT_APP_AUTHORITY_ID_old")]
    [StringLength(38)]
    public string? IntAppAuthorityIdOld { get; set; }

    [Column("INT_APP_AUTHORITY_ID")]
    public int? IntAppAuthorityId { get; set; }

    [Column("AA_USER_ID_old")]
    [StringLength(38)]
    public string? AaUserIdOld { get; set; }

    [Column("AA_USER_ID")]
    public int? AaUserId { get; set; }

    [Column("MOBILE_NO_old")]
    [StringLength(38)]
    public string? MobileNoOld { get; set; }

    [Column("MOBILE_NO")]
    public int? MobileNo { get; set; }

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
}
