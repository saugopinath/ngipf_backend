using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ho_sanc_auth_mst", Schema = "ihrms_master")]
public partial class HrMdGenHoSancAuthMst
{
    [Column("WEF", TypeName = "timestamp without time zone")]
    public DateTime Wef { get; set; }

    [Column("CREATED_ON", TypeName = "timestamp without time zone")]
    public DateTime CreatedOn { get; set; }

    [Column("LAST_UPDATED_ON", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("TAG_FLAG")]
    [StringLength(1)]
    public string? TagFlag { get; set; }

    [Column("LOCKED_FLAG")]
    [StringLength(1)]
    public string? LockedFlag { get; set; }

    [Column("LOCKED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime? LockedTimestamp { get; set; }

    [Column("UNLOCKED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime? UnlockedTimestamp { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_MST_ID_old")]
    [StringLength(38)]
    public string? IntHoDecSancAuthMstIdOld { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_MST_ID")]
    public int? IntHoDecSancAuthMstId { get; set; }

    [Column("REQUEST_ID_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("REQUEST_ID")]
    public int? RequestId { get; set; }

    [Column("CREATED_BY_old")]
    [StringLength(38)]
    public string? CreatedByOld { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_ROLE_old")]
    [StringLength(38)]
    public string? CreatedRoleOld { get; set; }

    [Column("CREATED_ROLE")]
    public int? CreatedRole { get; set; }

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

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("INT_MM_GEN_WF_MOD_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmGenWfModTypeIdOld { get; set; }

    [Column("INT_MM_GEN_WF_MOD_TYPE_ID")]
    public int? IntMmGenWfModTypeId { get; set; }

    [Column("INT_CADRE_ID_old")]
    [StringLength(38)]
    public string? IntCadreIdOld { get; set; }

    [Column("INT_CADRE_ID")]
    public int? IntCadreId { get; set; }

    [Column("INT_P_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntPDeptIdOld { get; set; }

    [Column("INT_P_DEPT_ID")]
    public int? IntPDeptId { get; set; }

    [Column("INT_SERVICE_ID_old")]
    [StringLength(38)]
    public string? IntServiceIdOld { get; set; }

    [Column("INT_SERVICE_ID")]
    public int? IntServiceId { get; set; }

    [Column("INT_GRP_ID_old")]
    [StringLength(38)]
    public string? IntGrpIdOld { get; set; }

    [Column("INT_GRP_ID")]
    public int? IntGrpId { get; set; }

    [Column("INT_POST_ID_old")]
    [StringLength(38)]
    public string? IntPostIdOld { get; set; }

    [Column("INT_POST_ID")]
    public int? IntPostId { get; set; }

    [Column("SAME_GROUP_NO_old")]
    [StringLength(38)]
    public string? SameGroupNoOld { get; set; }

    [Column("SAME_GROUP_NO")]
    public int? SameGroupNo { get; set; }

    [Column("INT_LOCKEDBY_USER_ID_old")]
    [StringLength(38)]
    public string? IntLockedbyUserIdOld { get; set; }

    [Column("INT_LOCKEDBY_USER_ID")]
    public int? IntLockedbyUserId { get; set; }

    [Column("INT_LOCKEDBY_USER_ROLE_old")]
    [StringLength(38)]
    public string? IntLockedbyUserRoleOld { get; set; }

    [Column("INT_LOCKEDBY_USER_ROLE")]
    public int? IntLockedbyUserRole { get; set; }

    [Column("INT_LOCKEDBY_BCO_ID_old")]
    [StringLength(38)]
    public string? IntLockedbyBcoIdOld { get; set; }

    [Column("INT_LOCKEDBY_BCO_ID")]
    public int? IntLockedbyBcoId { get; set; }

    [Column("INT_UNLOCKEDBY_USER_ID_old")]
    [StringLength(38)]
    public string? IntUnlockedbyUserIdOld { get; set; }

    [Column("INT_UNLOCKEDBY_USER_ID")]
    public int? IntUnlockedbyUserId { get; set; }

    [Column("INT_UNLOCKEDBY_USER_ROLE_old")]
    [StringLength(38)]
    public string? IntUnlockedbyUserRoleOld { get; set; }

    [Column("INT_UNLOCKEDBY_USER_ROLE")]
    public int? IntUnlockedbyUserRole { get; set; }

    [Column("INT_UNLOCKEDBY_BCO_ID_old")]
    [StringLength(38)]
    public string? IntUnlockedbyBcoIdOld { get; set; }

    [Column("INT_UNLOCKEDBY_BCO_ID")]
    public int? IntUnlockedbyBcoId { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_MST_ID_P_old")]
    [StringLength(38)]
    public string? IntHoDecSancAuthMstIdPOld { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_MST_ID_P")]
    public int? IntHoDecSancAuthMstIdP { get; set; }

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmGenWfModSubtypeIdOld { get; set; }

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID")]
    public int? IntMmGenWfModSubtypeId { get; set; }
}
