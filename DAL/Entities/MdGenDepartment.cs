using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("md_gen_department", Schema = "ifmsadmin")]
public partial class MdGenDepartment
{
    [Column("department_code")]
    [StringLength(2)]
    public string? DepartmentCode { get; set; }

    [Column("parent_dept_code")]
    [StringLength(3)]
    public string? ParentDeptCode { get; set; }

    [Column("demand_no")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("description")]
    [StringLength(100)]
    public string? Description { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_level_id_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("int_level_id")]
    public int? IntLevelId { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("upto_fin_year_old")]
    [StringLength(38)]
    public string? UptoFinYearOld { get; set; }

    [Column("upto_fin_year")]
    public int? UptoFinYear { get; set; }

    [Column("int_dept_id_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("int_dept_id")]
    public int IntDeptId { get; set; }
}
