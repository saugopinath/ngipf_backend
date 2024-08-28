using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ho_sanc_auth_det_wf", Schema = "ihrms_master")]
public partial class HrMdGenHoSancAuthDetWf
{
    [Column("HOO_AA_FLAG")]
    [StringLength(50)]
    public string? HooAaFlag { get; set; }

    [Column("WEF", TypeName = "timestamp without time zone")]
    public DateTime Wef { get; set; }

    [Column("CREATED_ON", TypeName = "timestamp without time zone")]
    public DateTime CreatedOn { get; set; }

    [Column("LAST_UPDATED_ON", TypeName = "timestamp without time zone")]
    public DateTime LastUpdatedOn { get; set; }

    [Column("WORKFLOW_STATUS_FLAG")]
    [StringLength(10)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("TAG_FLAG")]
    [StringLength(1)]
    public string? TagFlag { get; set; }

    [Column("FORWARD_HOO_AA_FLAG")]
    [StringLength(50)]
    public string? ForwardHooAaFlag { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_DET_ID_WF_old")]
    [StringLength(38)]
    public string? IntHoDecSancAuthDetIdWfOld { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_DET_ID_WF")]
    public int? IntHoDecSancAuthDetIdWf { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_DET_ID_old")]
    [StringLength(38)]
    public string? IntHoDecSancAuthDetIdOld { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_DET_ID")]
    public int? IntHoDecSancAuthDetId { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_MST_ID_old")]
    [StringLength(38)]
    public string? IntHoDecSancAuthMstIdOld { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_MST_ID")]
    public int? IntHoDecSancAuthMstId { get; set; }

    [Column("INT_HOO_AA_ID_old")]
    [StringLength(38)]
    public string? IntHooAaIdOld { get; set; }

    [Column("INT_HOO_AA_ID")]
    public int? IntHooAaId { get; set; }

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

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmGenWfModSubtypeIdOld { get; set; }

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID")]
    public int? IntMmGenWfModSubtypeId { get; set; }

    [Column("DISTRIBUTION_FLAG_old")]
    [StringLength(38)]
    public string? DistributionFlagOld { get; set; }

    [Column("DISTRIBUTION_FLAG")]
    public int? DistributionFlag { get; set; }

    [Column("TO_WHOM_old")]
    [StringLength(38)]
    public string? ToWhomOld { get; set; }

    [Column("TO_WHOM")]
    public int? ToWhom { get; set; }

    [Column("INT_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("INT_DEPT_ID")]
    public int? IntDeptId { get; set; }

    [Column("INT_LEVEL_ID_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("INT_LEVEL_ID")]
    public int? IntLevelId { get; set; }

    [Column("INT_FORWARD_HOO_AA_ID_old")]
    [StringLength(38)]
    public string? IntForwardHooAaIdOld { get; set; }

    [Column("INT_FORWARD_HOO_AA_ID")]
    public int? IntForwardHooAaId { get; set; }
}
