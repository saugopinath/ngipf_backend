using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_hoo_aa_map_wf", Schema = "ihrms_master")]
public partial class HrMmGenHooAaMapWf
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("WORKFLOW_STATUS_FLAG")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("LAST_UPDATED_ON")]
    public DateOnly LastUpdatedOn { get; set; }

    [Column("TAG_FLAG")]
    [StringLength(1)]
    public string? TagFlag { get; set; }

    [Column("APPROVED_FLAG")]
    [StringLength(1)]
    public string? ApprovedFlag { get; set; }

    [Column("WEF")]
    public DateOnly Wef { get; set; }

    [Column("NODAL_CODE")]
    [StringLength(20)]
    public string? NodalCode { get; set; }

    [Column("INT_MM_GEN_H_A_MAP_ID_WF_old")]
    [StringLength(38)]
    public string? IntMmGenHAMapIdWfOld { get; set; }

    [Column("INT_MM_GEN_H_A_MAP_ID_WF")]
    public int? IntMmGenHAMapIdWf { get; set; }

    [Column("INT_MM_GEN_H_A_MAP_ID_old")]
    [StringLength(38)]
    public string? IntMmGenHAMapIdOld { get; set; }

    [Column("INT_MM_GEN_H_A_MAP_ID")]
    public int? IntMmGenHAMapId { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID")]
    public int? IntHeadOfOfficeId { get; set; }

    [Column("INT_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("INT_DEPT_ID")]
    public int? IntDeptId { get; set; }

    [Column("INT_APP_AUTHORITY_ID_old")]
    [StringLength(38)]
    public string? IntAppAuthorityIdOld { get; set; }

    [Column("INT_APP_AUTHORITY_ID")]
    public int? IntAppAuthorityId { get; set; }

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

    [Column("LAST_UPDATED_BY_ROLE_old")]
    [StringLength(38)]
    public string? LastUpdatedByRoleOld { get; set; }

    [Column("LAST_UPDATED_BY_ROLE")]
    public int? LastUpdatedByRole { get; set; }

    [Column("INT_NODAL_ID_old")]
    [StringLength(38)]
    public string? IntNodalIdOld { get; set; }

    [Column("INT_NODAL_ID")]
    public int? IntNodalId { get; set; }

    [Column("INT_LEVEL_ID_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("INT_LEVEL_ID")]
    public int? IntLevelId { get; set; }
}
