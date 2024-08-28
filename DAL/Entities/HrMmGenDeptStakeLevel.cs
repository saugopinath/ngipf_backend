using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_dept_stake_level", Schema = "ihrms_master")]
public partial class HrMmGenDeptStakeLevel
{
    [Column("DEMAND_NO")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("DEPARTMENT_CODE")]
    [StringLength(2)]
    public string? DepartmentCode { get; set; }

    [Column("DEPT_CODE")]
    [StringLength(100)]
    public string? DeptCode { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(100)]
    public string? Description { get; set; }

    [Column("ACTIVE")]
    [StringLength(1)]
    public string? Active { get; set; }

    [Column("LEVEL_DESC_FLAG")]
    [StringLength(4)]
    public string? LevelDescFlag { get; set; }

    [Column("INT_DEPT_STAKE_LEVEL_ID_old")]
    [StringLength(38)]
    public string? IntDeptStakeLevelIdOld { get; set; }

    [Column("INT_DEPT_STAKE_LEVEL_ID")]
    public int? IntDeptStakeLevelId { get; set; }

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

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }
}
