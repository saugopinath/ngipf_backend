using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_head_of_dept", Schema = "ihrms_master")]
public partial class HrMmGenHeadOfDept
{
    [Column("DEPARTMENT_CODE")]
    [StringLength(2)]
    public string? DepartmentCode { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(60)]
    public string? Description { get; set; }

    [Column("DEMAND_NO")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("HEAD_OF_DEPT_CODE")]
    [StringLength(10)]
    public string? HeadOfDeptCode { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("APPROVE_DATE")]
    public DateOnly? ApproveDate { get; set; }

    [Column("GO_NUMBER")]
    [StringLength(50)]
    public string? GoNumber { get; set; }

    [Column("GO_DATE")]
    public DateOnly? GoDate { get; set; }

    [Column("INT_HEAD_OF_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfDeptIdOld { get; set; }

    [Column("INT_HEAD_OF_DEPT_ID")]
    public int? IntHeadOfDeptId { get; set; }

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
}
