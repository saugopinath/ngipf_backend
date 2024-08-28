using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_workflow", Schema = "ihrms_master")]
public partial class HrMmGenWorkflow
{
    [Column("WF_DESC")]
    [StringLength(300)]
    public string? WfDesc { get; set; }

    [Column("STATUS")]
    [MaxLength(1)]
    public char? Status { get; set; }

    [Column("CREATED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("EXCEPTION_NORMAL")]
    [StringLength(2)]
    public string? ExceptionNormal { get; set; }

    [Column("INT_WF_ID_old")]
    [StringLength(38)]
    public string? IntWfIdOld { get; set; }

    [Column("INT_WF_ID")]
    public int? IntWfId { get; set; }

    [Column("INT_MM_GEN_WF_MOD_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmGenWfModTypeIdOld { get; set; }

    [Column("INT_MM_GEN_WF_MOD_TYPE_ID")]
    public int? IntMmGenWfModTypeId { get; set; }

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmGenWfModSubtypeIdOld { get; set; }

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID")]
    public int? IntMmGenWfModSubtypeId { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID")]
    public int? IntHeadOfOfficeId { get; set; }

    [Column("INT_REQUEST_ID_old")]
    [StringLength(38)]
    public string? IntRequestIdOld { get; set; }

    [Column("INT_REQUEST_ID")]
    public int? IntRequestId { get; set; }

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

    [Column("CREATED_ROLE_ID_old")]
    [StringLength(38)]
    public string? CreatedRoleIdOld { get; set; }

    [Column("CREATED_ROLE_ID")]
    public int? CreatedRoleId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("MODIFIED_ROLE_ID_old")]
    [StringLength(38)]
    public string? ModifiedRoleIdOld { get; set; }

    [Column("MODIFIED_ROLE_ID")]
    public int? ModifiedRoleId { get; set; }
}
