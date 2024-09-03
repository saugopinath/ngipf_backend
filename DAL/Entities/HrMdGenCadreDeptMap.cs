using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_cadre_dept_map", Schema = "ihrms_master")]
public partial class HrMdGenCadreDeptMap
{
    [Column("CADRE_ABBR")]
    [StringLength(100)]
    public string? CadreAbbr { get; set; }

    [Column("CADRE_NAME")]
    [StringLength(200)]
    public string? CadreName { get; set; }

    [Column("DEPARTMENT_NAME")]
    [StringLength(100)]
    public string? DepartmentName { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("INT_CADRE_DEPT_MAP_ID_old")]
    [StringLength(38)]
    public string? IntCadreDeptMapIdOld { get; set; }

    [Column("INT_CADRE_DEPT_MAP_ID")]
    public int? IntCadreDeptMapId { get; set; }

    [Column("INT_CADRE_ID_old")]
    [StringLength(38)]
    public string? IntCadreIdOld { get; set; }

    [Column("INT_CADRE_ID")]
    public int? IntCadreId { get; set; }

    [Column("INT_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("INT_DEPT_ID")]
    public int? IntDeptId { get; set; }
}
