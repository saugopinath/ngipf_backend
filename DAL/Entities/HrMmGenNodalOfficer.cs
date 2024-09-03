using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_nodal_officer", Schema = "ihrms_master")]
public partial class HrMmGenNodalOfficer
{
    [Column("NODAL_OFFICER_CODE")]
    [StringLength(15)]
    public string? NodalOfficerCode { get; set; }

    [Column("NODAL_OFFICER_NAME")]
    [StringLength(60)]
    public string? NodalOfficerName { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("APPROVE_DATE")]
    public DateOnly? ApproveDate { get; set; }

    [Column("INT_NODAL_OFFICER_ID_old")]
    [StringLength(38)]
    public string? IntNodalOfficerIdOld { get; set; }

    [Column("INT_NODAL_OFFICER_ID")]
    public int? IntNodalOfficerId { get; set; }

    [Column("INT_POST_ID_old")]
    [StringLength(38)]
    public string? IntPostIdOld { get; set; }

    [Column("INT_POST_ID")]
    public int? IntPostId { get; set; }

    [Column("INT_DESIGNATION_ID_old")]
    [StringLength(38)]
    public string? IntDesignationIdOld { get; set; }

    [Column("INT_DESIGNATION_ID")]
    public int? IntDesignationId { get; set; }

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

    [Column("INT_CREATED_BY_APP_AUTH_old")]
    [StringLength(38)]
    public string? IntCreatedByAppAuthOld { get; set; }

    [Column("INT_CREATED_BY_APP_AUTH")]
    public int? IntCreatedByAppAuth { get; set; }
}
