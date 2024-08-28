using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_hoo_group", Schema = "ihrms_master")]
public partial class HrMdGenHooGroup
{
    [Column("GROUP_NAME")]
    [StringLength(200)]
    public string? GroupName { get; set; }

    [Column("GROUP_CODE")]
    [StringLength(100)]
    public string? GroupCode { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("WEF")]
    public DateOnly Wef { get; set; }

    [Column("LAST_UPDATED_ON")]
    public DateOnly LastUpdatedOn { get; set; }

    [Column("APPROVED_FLAG")]
    [StringLength(1)]
    public string? ApprovedFlag { get; set; }

    [Column("INT_HR_MD_GEN_GROUP_old")]
    [StringLength(38)]
    public string? IntHrMdGenGroupOld { get; set; }

    [Column("INT_HR_MD_GEN_GROUP")]
    public int? IntHrMdGenGroup { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID")]
    public int? IntHeadOfOfficeId { get; set; }

    [Column("GROUP_TYPE_old")]
    [StringLength(38)]
    public string? GroupTypeOld { get; set; }

    [Column("GROUP_TYPE")]
    public int? GroupType { get; set; }

    [Column("REQUEST_ID_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("REQUEST_ID")]
    public int? RequestId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("LAST_UPDATED_BY_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("LAST_UPDATED_BY")]
    public int? LastUpdatedBy { get; set; }

    [Column("LAST_UPDATED_ROLE_old")]
    [StringLength(38)]
    public string? LastUpdatedRoleOld { get; set; }

    [Column("LAST_UPDATED_ROLE")]
    public int? LastUpdatedRole { get; set; }
}
