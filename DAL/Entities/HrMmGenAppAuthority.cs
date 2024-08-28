using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_app_authority", Schema = "ihrms_master")]
public partial class HrMmGenAppAuthority
{
    [Column("APP_AUTHORITY_CODE")]
    [StringLength(15)]
    public string? AppAuthorityCode { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(1000)]
    public string? Description { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("APPROVE_DATE")]
    public DateOnly? ApproveDate { get; set; }

    [Column("DELEGATE_FLAG")]
    [StringLength(1)]
    public string? DelegateFlag { get; set; }

    [Column("HOD_FLAG")]
    [StringLength(1)]
    public string? HodFlag { get; set; }

    [Column("SANCTION_FLAG")]
    [StringLength(1)]
    public string? SanctionFlag { get; set; }

    [Column("DEMAND_NO")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("INT_APP_AUTHORITY_ID_old")]
    [StringLength(38)]
    public string? IntAppAuthorityIdOld { get; set; }

    [Column("INT_APP_AUTHORITY_ID")]
    public int? IntAppAuthorityId { get; set; }

    [Column("INT_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("INT_DEPT_ID")]
    public int? IntDeptId { get; set; }

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

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("APPROVE_FLAG_old")]
    [StringLength(38)]
    public string? ApproveFlagOld { get; set; }

    [Column("APPROVE_FLAG")]
    public int? ApproveFlag { get; set; }

    [Column("APPROVE_BY_old")]
    [StringLength(38)]
    public string? ApproveByOld { get; set; }

    [Column("APPROVE_BY")]
    public int? ApproveBy { get; set; }

    [Column("LEVEL_ID_old")]
    [StringLength(38)]
    public string? LevelIdOld { get; set; }

    [Column("LEVEL_ID")]
    public int? LevelId { get; set; }

    [Column("DELEGATE_BY_old")]
    [StringLength(38)]
    public string? DelegateByOld { get; set; }

    [Column("DELEGATE_BY")]
    public int? DelegateBy { get; set; }

    [Column("INT_CREATED_BY_APP_AUTH_old")]
    [StringLength(38)]
    public string? IntCreatedByAppAuthOld { get; set; }

    [Column("INT_CREATED_BY_APP_AUTH")]
    public int? IntCreatedByAppAuth { get; set; }
}
