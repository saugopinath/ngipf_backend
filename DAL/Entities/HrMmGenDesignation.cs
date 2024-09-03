using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_designation", Schema = "ihrms_master")]
public partial class HrMmGenDesignation
{
    [Column("DESIGNATION")]
    [StringLength(300)]
    public string? Designation { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("HEAD_OF_OFFICE")]
    [StringLength(1)]
    public string? HeadOfOffice { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("NGIPF_FLAG")]
    [StringLength(1)]
    public string? NgipfFlag { get; set; }

    [Column("DESIG_ABBR")]
    [StringLength(10)]
    public string? DesigAbbr { get; set; }

    [Column("INT_DESIGNATION_ID_old")]
    [StringLength(38)]
    public string? IntDesignationIdOld { get; set; }

    [Column("INT_DESIGNATION_ID")]
    public int? IntDesignationId { get; set; }

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

    [Column("INT_POST_ID_old")]
    [StringLength(38)]
    public string? IntPostIdOld { get; set; }

    [Column("INT_POST_ID")]
    public int? IntPostId { get; set; }
}
