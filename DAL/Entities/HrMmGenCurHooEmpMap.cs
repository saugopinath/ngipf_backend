using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_cur_hoo_emp_map", Schema = "ihrms_master")]
public partial class HrMmGenCurHooEmpMap
{
    [Column("WEF")]
    public DateOnly? Wef { get; set; }

    [Column("MAP_BY_FLAG")]
    [StringLength(5)]
    public string? MapByFlag { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("INT_CUR_HOO_EMP_MAP_old")]
    [StringLength(38)]
    public string? IntCurHooEmpMapOld { get; set; }

    [Column("INT_CUR_HOO_EMP_MAP")]
    public int? IntCurHooEmpMap { get; set; }

    [Column("INT_EMPLOYEE_ID_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("INT_EMPLOYEE_ID")]
    public int? IntEmployeeId { get; set; }

    [Column("INT_HOO_ID_old")]
    [StringLength(38)]
    public string? IntHooIdOld { get; set; }

    [Column("INT_HOO_ID")]
    public int? IntHooId { get; set; }

    [Column("MAP_BY_ID_old")]
    [StringLength(38)]
    public string? MapByIdOld { get; set; }

    [Column("MAP_BY_ID")]
    public int? MapById { get; set; }

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

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }
}
